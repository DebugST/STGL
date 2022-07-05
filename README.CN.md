[![.Net35](https://img.shields.io/badge/DotNet-3.5-blue)](https://www.microsoft.com/zh-cn/download/details.aspx?id=25150)
[![.NetCore](https://img.shields.io/badge/DotNet-Core-blueviolet)](https://dotnet.microsoft.com/)
[![LICENSE](https://img.shields.io/badge/License-MIT-green)](https://github.com/DebugST/STNodeEditor/blob/main/LICENSE)

## 学习OpenGL
[https://learnopengl.com/](https://learnopengl.com/)

[https://learnopengl-cn.readthedocs.io/](https://learnopengl-cn.readthedocs.io/)

## 构建
STGL使用VS2010+Net3.5创建，所以语法几乎兼容所有.Net平台。

## STGL
STGL是一个非常轻量级的OpenGL封装。目前STGL仅仅是将OpenGL中的函数移植到了C#中，并没有其他额外Class封装。所以在使用STGL的时候和使用原生OpenGL的感觉非常相似，非常适合用于学习OpenGL。
甚至你可以直接从[https://learnopengl.com/](https://learnopengl.com/)拷贝C语言的源代码到C#中做一些简单的修改就可以直接运行，比如：
```
glfwXXX  替换成 GLFW.XXX
GLFW_XXX 替换成 GLFW.XXX
glXXX    替换成 GL.XXX
GL_XXX   替换成 GL.GL_XXX
```
当然由于指针的关系，部分函数做了重载，如：glGenXXX、glCreateXXX、glDeleteXXX、glGetXXX 以及一些需要字符串或数组的函数
重载的函数包含在`GL.Overload.cs`中

## 代码组织

* `GL.Const.cs`
    * GL中的所有常量值
* `GL.Method.DebugCallback.cs`
    * GL中的调试包含的回调设置
* `GL.Method.Safe.cs`
    * GL原生函数中不包含指针且可以直接被C#调用的函数
* `GL.Method.Unsafe.cs`
    * GL原生函数中包含指针且做了部分转换的函数 如: void* 替换成 IntPtr
* `GL.Method.Overload.cs`
    * GL原生函数中包含指针的函数且重载成了C#基本类型的函数
* `GLNative.Method.cs`
    * GL所有原生函数。部分被`unsafe`关键字修饰并保留了指针，如果在`GL.Method.XX.cs`中的函数如果出现转换问题可以直接使用`GLNative.Method.cs`中的函数，当然你的代码也必须使用unsafe修饰并使用指针。
* `GLNativeDelegate.cs`
    * GL中所有函数的签名，因为GL函数是通过`GetProcAddress`获取地址并转换而来的
* `GLNativeDeclare.cs`
    * GL中所有函数字符串名称与`Delegate`的对应关系，在`GL.InitAll()`中被使用
    
所有的`GL.Method.XX`最终都调用`GLNative.Method`。
```cs
/// <summary>
/// [Overload] - void ShaderSource(uint shader,int count,byte** str,int* length)
/// </summary>
public unsafe static void ShaderSource(uint shader, string str) {
    GL.ShaderSource(shader, new string[] { str }, 1);
}
/// <summary>
/// [Overload] - void ShaderSource(uint shader,int count,byte** str,int* length)
/// </summary>
public unsafe static void ShaderSource(uint shader, string[] strs) {
    GL.ShaderSource(shader, strs, strs.Length);
}
/// <summary>
/// [Overload] - void ShaderSource(uint shader,int count,byte** str,int* length)
/// </summary>
public unsafe static void ShaderSource(uint shader, string[] strs, int count) {
    int[] nLens = new int[strs.Length];
    IntPtr ptr = MarshalExtend.AllocStringArr(strs, nLens, Encoding.UTF8);
    try {
        fixed (int* pNLens = &nLens[0]) {
            GLNative.glShaderSource(shader, strs.Length, (byte**)ptr, pNLens);
        }
    } finally {
        MarshalExtend.FreeStringArr(ptr, strs.Length);
    }
}
```
所有的`GLNative.Method`都是通过`GetProcAddress`获取地址并转换而来。
```cs
public unsafe static void glShaderSource(uint shader, int count, byte** str, int* length) {
    var _F = _GetProc<GLNativeDelegate.FNglShaderSource>("glShaderSource");
    _F(shader, count, str, length);
}

private static T _GetProc<T>(string strName) {
    if (!m_dic_proc.ContainsKey(strName)) {
        if (m_getter == null) {
            throw new InvalidOperationException(
                "GL is not initialized, please call [GL.Init()] or [GL.InitAll()] to initialize it first."
            );
        }
        IntPtr ptr = m_getter(strName);
        if (ptr != IntPtr.Zero) {
            var func = Marshal.GetDelegateForFunctionPointer(ptr, typeof(T));
            m_dic_proc.Add(strName, func);
            GLNative.InitedFunctions++;
        }
        // _GetProc will not write null to m_dic_proc when it cannot get Proc, but GL.InitAll will.
    }
    if (m_dic_proc.ContainsKey(strName)) {
        object obj = m_dic_proc[strName];
        if (obj != null) {
            return (T)obj;
        }
    }
    throw new PlatformNotSupportedException(
        "The [" + strName + "] function cannot be initialized. " +
        "Or maybe the current OpenGL version [" + GLNative.Info.Version + "]  does not support this function, " +
        "Of course it is also possible that the stupid author wrote the bug."
    );
}
```

## 依赖
STGL依赖`GLFW`项目，在STGL的库中已打包`Windows`和`Mac`的`GLFW`库，支持：
* Windows_NT_32
* Windows_NT_64
* Mac_X86_64
* Mac_Arm_64

当程序运行时，`STGL`会自动识别当前系统版本以及应用程序目标平台并解压其中一个和`LICENSE`文件到`runtime`目录中
如果需要在Linux系统中允许，可以下载GLFW的源码并编译
[https://www.glfw.org/docs/latest/compile_guide.html#compile_deps_x11](https://www.glfw.org/docs/latest/compile_guide.html#compile_deps_x11)
并且在CMake的时候需要加上`-D BUILD_SHARED_LIBS=ON`

然后将编编译号的`so`文件拷贝至`runtime`目录中并命名为`glfw3`
