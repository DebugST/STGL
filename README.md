[![.Net35](https://img.shields.io/badge/DotNet-3.5-blue)](https://www.microsoft.com/zh-cn/download/details.aspx?id=25150)
[![.NetCore](https://img.shields.io/badge/DotNet-Core-blueviolet)](https://dotnet.microsoft.com/)
[![LICENSE](https://img.shields.io/badge/License-MIT-green)](https://github.com/DebugST/STNodeEditor/blob/main/LICENSE)

[简体中文](./README.CN.md)

## Learn OpenGL
[https://learnopengl.com/](https://learnopengl.com/)

[https://learnopengl-cn.readthedocs.io/](https://learnopengl-cn.readthedocs.io/)

## Buiding
STGL was created by VS2010+Net3.5, So the syntax is compatible with almost all .Net platforms.

## STGL
STGL is a very lightweight OpenGL library. At present, STGL only transplants the functions in OpenGL to C#, and there is no other additional Class encapsulation. So when using STGL, it feels very similar to using native OpenGL, which is very suitable for learning OpenGL.
Even you can directly copy the source code of C language from [https://learnopengl.com/](https://learnopengl.com/) to C# and make some simple modifications to run it directly, such as:
```
glfwXXX  replace to GLFW.XXX
GLFW_XXX replace to GLFW.XXX
glXXX    replace to GL.XXX
GL_XXX   replace to GL.GL_XXX
```
Of course, due to pointers, some functions are overloaded, such as: glGenXXX, glCreateXXX, glDeleteXXX, glGetXXX, and some functions that require strings or arrays
Overloaded functions are contained in `GL.Overload.cs`

## Code Organization

* `GL.Const.cs`
    * All constant values in GL
* `GL.Method.DebugCallback.cs`
    * Some debug callbacks in GL
* `GL.Method.Safe.cs`
    * Functions that do not contain pointers in GL native functions and can be directly called by C#.
* `GL.Method.Unsafe.cs`
    * GL native functions contain pointers and partially converted functions such as: `void*` is replaced with `IntPtr`.
* `GL.Method.Overload.cs`
    * GL native functions contain pointer functions and are overloaded into C# basic types of functions
* `GLNative.Method.cs`
    * All native functions of GL. Part of it is modified by the `unsafe` keyword and retains the pointer. If the function in `GL.Method.XX.cs` has conversion problems, you can directly use the function in `GLNative.Method.cs`. Of course, your code also Must be decorated with unsafe and use pointers.
* `GLNativeDelegate.cs`
    * The signatures of all functions in GL, because the GL functions are obtained by `GetProcAddress` and converted from addresses.
* `GLNativeDeclare.cs`
    * All function string names in GL correspond to `Delegate`, used in `GL.InitAll()`.
    
All `GL.Method.XX` call `GLNative.Method`.
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
All `GLNative.Method` are obtained through `GetProcAddress` address and converted.
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

## Dependent project
STGL relies on the `GLFW` project. The `GLFW` library of `Windows` and `Mac` has been packaged in the STGL library, supporting:
* Windows_NT_32
* Windows_NT_64
* Mac_X86_64
* Mac_Arm_64

![Windows](https://s3.bmp.ovh/imgs/2022/07/06/eb03f437a406acd8.png)

![Mac](https://s3.bmp.ovh/imgs/2022/07/06/602a7aa7f193a21c.png)

![Ubuntu](https://s3.bmp.ovh/imgs/2022/07/06/f1f1910e2e803683.png)

When the program is run, `STGL` will automatically detect the current system version and application platform target and extract one of them and the `LICENSE` file into the `runtime` directory.

If you need to allow it in the Linux system, you can download the source code of GLFW and compile it:

[https://www.glfw.org/docs/latest/compile_guide.html#compile_deps_x11](https://www.glfw.org/docs/latest/compile_guide.html#compile_deps_x11)

And you need to add `-D BUILD_SHARED_LIBS=ON` in CMake.

Then copy the compiled `so` file to the `runtime` directory and name it `glfw3`
