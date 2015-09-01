﻿module Glfw3

open System
open System.Runtime.InteropServices

type Action =
    | RELEASE = 0
    | PRESS   = 1
    | REPEAT  = 2

type Key =
    | KEY_UNKNOWN            = -1
    | KEY_SPACE              = 32
    | KEY_APOSTROPHE         = 39  (* ' *)
    | KEY_COMMA              = 44  (* , *)
    | KEY_MINUS              = 45  (* - *)
    | KEY_PERIOD             = 46  (* . *)
    | KEY_SLASH              = 47  (* / *)
    | KEY_0                  = 48
    | KEY_1                  = 49
    | KEY_2                  = 50
    | KEY_3                  = 51
    | KEY_4                  = 52
    | KEY_5                  = 53
    | KEY_6                  = 54
    | KEY_7                  = 55
    | KEY_8                  = 56
    | KEY_9                  = 57
    | KEY_SEMICOLON          = 59  (* ; *)
    | KEY_EQUAL              = 61  (* = *)
    | KEY_A                  = 65
    | KEY_B                  = 66
    | KEY_C                  = 67
    | KEY_D                  = 68
    | KEY_E                  = 69
    | KEY_F                  = 70
    | KEY_G                  = 71
    | KEY_H                  = 72
    | KEY_I                  = 73
    | KEY_J                  = 74
    | KEY_K                  = 75
    | KEY_L                  = 76
    | KEY_M                  = 77
    | KEY_N                  = 78
    | KEY_O                  = 79
    | KEY_P                  = 80
    | KEY_Q                  = 81
    | KEY_R                  = 82
    | KEY_S                  = 83
    | KEY_T                  = 84
    | KEY_U                  = 85
    | KEY_V                  = 86
    | KEY_W                  = 87
    | KEY_X                  = 88
    | KEY_Y                  = 89
    | KEY_Z                  = 90
    | KEY_LEFT_BRACKET       = 91  (* [ *)
    | KEY_BACKSLASH          = 92  (* \ *)
    | KEY_RIGHT_BRACKET      = 93  (* ] *)
    | KEY_GRAVE_ACCENT       = 96  (* ` *)
    | KEY_WORLD_1            = 161 (* non-US #1 *)
    | KEY_WORLD_2            = 162 (* non-US #2 *)
    | KEY_ESCAPE             = 256
    | KEY_ENTER              = 257
    | KEY_TAB                = 258
    | KEY_BACKSPACE          = 259
    | KEY_INSERT             = 260
    | KEY_DELETE             = 261
    | KEY_RIGHT              = 262
    | KEY_LEFT               = 263
    | KEY_DOWN               = 264
    | KEY_UP                 = 265
    | KEY_PAGE_UP            = 266
    | KEY_PAGE_DOWN          = 267
    | KEY_HOME               = 268
    | KEY_END                = 269
    | KEY_CAPS_LOCK          = 280
    | KEY_SCROLL_LOCK        = 281
    | KEY_NUM_LOCK           = 282
    | KEY_PRINT_SCREEN       = 283
    | KEY_PAUSE              = 284
    | KEY_F1                 = 290
    | KEY_F2                 = 291
    | KEY_F3                 = 292
    | KEY_F4                 = 293
    | KEY_F5                 = 294
    | KEY_F6                 = 295
    | KEY_F7                 = 296
    | KEY_F8                 = 297
    | KEY_F9                 = 298
    | KEY_F10                = 299
    | KEY_F11                = 300
    | KEY_F12                = 301
    | KEY_F13                = 302
    | KEY_F14                = 303
    | KEY_F15                = 304
    | KEY_F16                = 305
    | KEY_F17                = 306
    | KEY_F18                = 307
    | KEY_F19                = 308
    | KEY_F20                = 309
    | KEY_F21                = 310
    | KEY_F22                = 311
    | KEY_F23                = 312
    | KEY_F24                = 313
    | KEY_F25                = 314
    | KEY_KP_0               = 320
    | KEY_KP_1               = 321
    | KEY_KP_2               = 322
    | KEY_KP_3               = 323
    | KEY_KP_4               = 324
    | KEY_KP_5               = 325
    | KEY_KP_6               = 326
    | KEY_KP_7               = 327
    | KEY_KP_8               = 328
    | KEY_KP_9               = 329
    | KEY_KP_DECIMAL         = 330
    | KEY_KP_DIVIDE          = 331
    | KEY_KP_MULTIPLY        = 332
    | KEY_KP_SUBTRACT        = 333
    | KEY_KP_ADD             = 334
    | KEY_KP_ENTER           = 335
    | KEY_KP_EQUAL           = 336
    | KEY_LEFT_SHIFT         = 340
    | KEY_LEFT_CONTROL       = 341
    | KEY_LEFT_ALT           = 342
    | KEY_LEFT_SUPER         = 343
    | KEY_RIGHT_SHIFT        = 344
    | KEY_RIGHT_CONTROL      = 345
    | KEY_RIGHT_ALT          = 346
    | KEY_RIGHT_SUPER        = 347
    | KEY_MENU               = 348
    | KEY_LAST               = 348

type Mod =
    | MOD_SHIFT              = 0x0001
    | MOD_CONTROL            = 0x0002
    | MOD_ALT                = 0x0004
    | MOD_SUPER              = 0x0008

type MouseButton =
    | BUTTON_1               = 0
    | BUTTON_2               = 1
    | BUTTON_3               = 2
    | BUTTON_4               = 3
    | BUTTON_5               = 4
    | BUTTON_6               = 5
    | BUTTON_7               = 6
    | BUTTON_8               = 7
    | BUTTON_LAST            = 7 // GLFW_MOUSE_BUTTON_8
    | BUTTON_LEFT            = 0 // GLFW_MOUSE_BUTTON_1
    | BUTTON_RIGHT           = 1 // GLFW_MOUSE_BUTTON_2
    | BUTTON_MIDDLE          = 2 // GLFW_MOUSE_BUTTON_3

type Joystick =
    | JOYSTICK_1             = 0
    | JOYSTICK_2             = 1
    | JOYSTICK_3             = 2
    | JOYSTICK_4             = 3
    | JOYSTICK_5             = 4
    | JOYSTICK_6             = 5
    | JOYSTICK_7             = 6
    | JOYSTICK_8             = 7
    | JOYSTICK_9             = 8
    | JOYSTICK_10            = 9
    | JOYSTICK_11            = 10
    | JOYSTICK_12            = 11
    | JOYSTICK_13            = 12
    | JOYSTICK_14            = 13
    | JOYSTICK_15            = 14
    | JOYSTICK_16            = 15
    | JOYSTICK_LAST          = 15 // GLFW_JOYSTICK_16

type Error =
    | NOT_INITIALIZED        = 0x00010001
    | NO_CURRENT_CONTEXT     = 0x00010002
    | INVALID_ENUM           = 0x00010003
    | INVALID_VALUE          = 0x00010004
    | OUT_OF_MEMORY          = 0x00010005
    | API_UNAVAILABLE        = 0x00010006
    | VERSION_UNAVAILABLE    = 0x00010007
    | PLATFORM_ERROR         = 0x00010008
    | FORMAT_UNAVAILABLE     = 0x00010009

type WindowHint =
    | FOCUSED                = 0x00020001
    | ICONIFIED              = 0x00020002
    | RESIZABLE              = 0x00020003
    | VISIBLE                = 0x00020004
    | DECORATED              = 0x00020005
    | AUTO_ICONIFY           = 0x00020006
    | FLOATING               = 0x00020007

    | RED_BITS               = 0x00021001
    | GREEN_BITS             = 0x00021002
    | BLUE_BITS              = 0x00021003
    | ALPHA_BITS             = 0x00021004
    | DEPTH_BITS             = 0x00021005
    | STENCIL_BITS           = 0x00021006
    | ACCUM_RED_BITS         = 0x00021007
    | ACCUM_GREEN_BITS       = 0x00021008
    | ACCUM_BLUE_BITS        = 0x00021009
    | ACCUM_ALPHA_BITS       = 0x0002100A
    | AUX_BUFFERS            = 0x0002100B
    | STEREO                 = 0x0002100C
    | SAMPLES                = 0x0002100D
    | SRGB_CAPABLE           = 0x0002100E
    | REFRESH_RATE           = 0x0002100F
    | DOUBLEBUFFER           = 0x00021010

    | CLIENT_API             = 0x00022001
    | CONTEXT_VERSION_MAJOR  = 0x00022002
    | CONTEXT_VERSION_MINOR  = 0x00022003
    | CONTEXT_REVISION       = 0x00022004
    | CONTEXT_ROBUSTNESS     = 0x00022005
    | OPENGL_FORWARD_COMPAT  = 0x00022006
    | OPENGL_DEBUG_CONTEXT   = 0x00022007
    | OPENGL_PROFILE         = 0x00022008
    | CONTEXT_RELEASE_BEHAVIOR = 0x00022009

    | OPENGL_API             = 0x00030001
    | OPENGL_ES_API          = 0x00030002

    | NO_ROBUSTNESS          =          0
    | NO_RESET_NOTIFICATION  = 0x00031001
    | LOSE_CONTEXT_ON_RESET  = 0x00031002

    | OPENGL_ANY_PROFILE     =          0
    | OPENGL_CORE_PROFILE    = 0x00032001
    | OPENGL_COMPAT_PROFILE  = 0x00032002

    | CURSOR                 = 0x00033001
    | STICKY_KEYS            = 0x00033002
    | STICKY_MOUSE_BUTTONS   = 0x00033003

    | CURSOR_NORMAL          = 0x00034001
    | CURSOR_HIDDEN          = 0x00034002
    | CURSOR_DISABLED        = 0x00034003

    | ANY_RELEASE_BEHAVIOR   =          0
    | RELEASE_BEHAVIOR_FLUSH = 0x00035001
    | RELEASE_BEHAVIOR_NONE  = 0x00035002

type Arrow =
    | ARROW_CURSOR           = 0x00036001
    | IBEAM_CURSOR           = 0x00036002
    | CROSSHAIR_CURSOR       = 0x00036003
    | HAND_CURSOR            = 0x00036004
    | HRESIZE_CURSOR         = 0x00036005
    | VRESIZE_CURSOR         = 0x00036006

type GLProc = delegate of unit -> unit

type Monitor(ptr: IntPtr) =
    member x.Value = ptr

type Window(ptr: IntPtr, ob: obj) =
    member x.Value = ptr
    member x.Object = ob

type Cursor(ptr: IntPtr) =
    member x.Value = ptr

type ErrorFun           = delegate of int * string                  -> unit
type WindowPosFun       = delegate of Window * int * int            -> unit
type WindowSizeFun      = delegate of Window * int * int            -> unit
type WindowCloseFun     = delegate of Window                        -> unit
type WindowRefreshFun   = delegate of Window                        -> unit
type WindowFocusFun     = delegate of Window * int                  -> unit
type WindowIconifyFun   = delegate of Window * int                  -> unit
type FramebufferSizeFun = delegate of Window * int * int            -> unit
type MouseButtonFun     = delegate of Window * int * int * int      -> unit
type CursorPosFun       = delegate of Window * double * double      -> unit
type CursorEnterFun     = delegate of Window * int                  -> unit
type ScrollFun          = delegate of Window * double * double      -> unit
type KeyFun             = delegate of Window * int * int * int * int -> unit
type CharFun            = delegate of Window * char                 -> unit
type CharModsFun        = delegate of Window * char * int           -> unit
type DropFun            = delegate of Window * string[]             -> unit
type MonitorFun         = delegate of Monitor * int                 -> unit

#nowarn "9"

[<StructAttribute; StructLayoutAttribute(LayoutKind.Sequential)>]
type VideoMode =
    val     width       : int
    val     height      : int
    val     redBits     : int
    val     greenBits   : int
    val     blueBits    : int
    val     refreshRate : int

[<StructAttribute; StructLayoutAttribute(LayoutKind.Sequential)>]
type Image =
    val     width       : int
    val     height      : int
    val     pixels      : nativeptr<byte>

[<StructAttribute; StructLayoutAttribute(LayoutKind.Sequential)>]
type GammaRamp =
    val     Red         : int[]
    val     Green       : int[]
    val     Blue        : int[]

    new(r, g, b) = { Red = r; Green = g; Blue = b }

[<AutoOpen>]
module private Native =
    let [<LiteralAttribute>] GLFW_DLL = @"glfw"


    type GLFWmonitor    = IntPtr
    type GLFWwindow     = IntPtr
    type GLFWcursor     = IntPtr

    type GLFWglproc             = delegate of unit                          -> unit
    type GLFWerrorfun           = delegate of int * [<MarshalAs(UnmanagedType.LPStr)>] error: string -> unit
    type GLFWwindowposfun       = delegate of GLFWwindow * int * int        -> unit
    type GLFWwindowsizefun      = delegate of GLFWwindow * int * int        -> unit
    type GLFWwindowclosefun     = delegate of GLFWwindow                    -> unit
    type GLFWwindowrefreshfun   = delegate of GLFWwindow                    -> unit
    type GLFWwindowfocusfun     = delegate of GLFWwindow * int              -> unit
    type GLFWwindowiconifyfun   = delegate of GLFWwindow * int              -> unit
    type GLFWframebuffersizefun = delegate of GLFWwindow * int * int        -> unit
    type GLFWmousebuttonfun     = delegate of GLFWwindow * int * int * int  -> unit
    type GLFWcursorposfun       = delegate of GLFWwindow * double * double  -> unit
    type GLFWcursorenterfun     = delegate of GLFWwindow * int              -> unit
    type GLFWscrollfun          = delegate of GLFWwindow * double * double  -> unit
    type GLFWkeyfun             = delegate of GLFWwindow * int * int * int * int    -> unit
    type GLFWcharfun            = delegate of GLFWwindow * uint32           -> unit
    type GLFWcharmodsfun        = delegate of GLFWwindow * uint32 * int     -> unit
    type GLFWdropfun            = delegate of GLFWwindow * int * IntPtr     -> unit // const char**
    type GLFWmonitorfun         = delegate of GLFWmonitor * int             -> unit


    [<StructAttribute; StructLayoutAttribute(LayoutKind.Sequential)>]
    type GLFWgammaramp =
        val     red         : IntPtr
        val     green       : IntPtr
        val     blue        : IntPtr
        val     size        : uint16

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern int glfwInit()

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern void glfwTerminate()

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern void glfwGetVersion([<Out>] int& major, [<Out>] int&  minor, [<Out>] int& rev)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern IntPtr glfwGetVersionString()

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern IntPtr glfwGetMonitors([<Out>]int& count)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern GLFWmonitor glfwGetPrimaryMonitor()

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern void glfwGetMonitorPos(GLFWmonitor monitor, [<Out>]int& xpos, [<Out>]int& ypos)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern void glfwGetMonitorPhysicalSize(GLFWmonitor monitor, [<Out>]int& widthMM, [<Out>]int& heightMM)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern IntPtr glfwGetMonitorName(GLFWmonitor monitor)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun cbfun)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun cbfun)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern IntPtr glfwGetVideoModes(GLFWmonitor monitor, [<Out>] int& count)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern IntPtr glfwGetVideoMode(GLFWmonitor monitor)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern void glfwSetGamma(GLFWmonitor monitor, float32 gamma)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern IntPtr glfwGetGammaRamp(GLFWmonitor monitor)

//    extern void glfwSetGammaRamp(GLFWmonitor* monitor, const GLFWgammaramp* ramp);

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern void glfwDefaultWindowHints()

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern void glfwWindowHint(int target, int hint)

    [<DllImportAttribute(GLFW_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)>]
    extern GLFWwindow glfwCreateWindow(int width, int height, [<MarshalAs(UnmanagedType.LPStr)>]string title, GLFWmonitor monitor, GLFWwindow share);

//    extern void glfwDestroyWindow(GLFWwindow* window);
//    extern int glfwWindowShouldClose(GLFWwindow* window);
//    extern void glfwSetWindowShouldClose(GLFWwindow* window, int value);
//    extern void glfwSetWindowTitle(GLFWwindow* window, const char* title);
//    extern void glfwGetWindowPos(GLFWwindow* window, int* xpos, int* ypos);
//    extern void glfwSetWindowPos(GLFWwindow* window, int xpos, int ypos);
//    extern void glfwGetWindowSize(GLFWwindow* window, int* width, int* height);
//    extern void glfwSetWindowSize(GLFWwindow* window, int width, int height);
//    extern void glfwGetFramebufferSize(GLFWwindow* window, int* width, int* height);
//    extern void glfwGetWindowFrameSize(GLFWwindow* window, int* left, int* top, int* right, int* bottom);
//    extern void glfwIconifyWindow(GLFWwindow* window);
//    extern void glfwRestoreWindow(GLFWwindow* window);
//    extern void glfwShowWindow(GLFWwindow* window);
//    extern void glfwHideWindow(GLFWwindow* window);
//    extern GLFWmonitor* glfwGetWindowMonitor(GLFWwindow* window);
//    extern int glfwGetWindowAttrib(GLFWwindow* window, int attrib);
//    extern void glfwSetWindowUserPointer(GLFWwindow* window, void* pointer);
//    extern void* glfwGetWindowUserPointer(GLFWwindow* window);
//    extern GLFWwindowposfun glfwSetWindowPosCallback(GLFWwindow* window, GLFWwindowposfun cbfun);
//    extern GLFWwindowsizefun glfwSetWindowSizeCallback(GLFWwindow* window, GLFWwindowsizefun cbfun);
//    extern GLFWwindowclosefun glfwSetWindowCloseCallback(GLFWwindow* window, GLFWwindowclosefun cbfun);
//    extern GLFWwindowrefreshfun glfwSetWindowRefreshCallback(GLFWwindow* window, GLFWwindowrefreshfun cbfun);
//    extern GLFWwindowfocusfun glfwSetWindowFocusCallback(GLFWwindow* window, GLFWwindowfocusfun cbfun);
//    extern GLFWwindowiconifyfun glfwSetWindowIconifyCallback(GLFWwindow* window, GLFWwindowiconifyfun cbfun);
//    extern GLFWframebuffersizefun glfwSetFramebufferSizeCallback(GLFWwindow* window, GLFWframebuffersizefun cbfun);
//    extern void glfwPollEvents(void);
//    extern void glfwWaitEvents(void);
//    extern void glfwPostEmptyEvent(void);
//    extern int glfwGetInputMode(GLFWwindow* window, int mode);
//    extern void glfwSetInputMode(GLFWwindow* window, int mode, int value);
//    extern int glfwGetKey(GLFWwindow* window, int key);
//    extern int glfwGetMouseButton(GLFWwindow* window, int button);
//    extern void glfwGetCursorPos(GLFWwindow* window, double* xpos, double* ypos);
//    extern void glfwSetCursorPos(GLFWwindow* window, double xpos, double ypos);
//    extern GLFWcursor* glfwCreateCursor(const GLFWimage* image, int xhot, int yhot);
//    extern GLFWcursor* glfwCreateStandardCursor(int shape);
//    extern void glfwDestroyCursor(GLFWcursor* cursor);
//    extern void glfwSetCursor(GLFWwindow* window, GLFWcursor* cursor);
//    extern GLFWkeyfun glfwSetKeyCallback(GLFWwindow* window, GLFWkeyfun cbfun);
//    extern GLFWcharfun glfwSetCharCallback(GLFWwindow* window, GLFWcharfun cbfun);
//    extern GLFWcharmodsfun glfwSetCharModsCallback(GLFWwindow* window, GLFWcharmodsfun cbfun);
//    extern GLFWmousebuttonfun glfwSetMouseButtonCallback(GLFWwindow* window, GLFWmousebuttonfun cbfun);
//    extern GLFWcursorposfun glfwSetCursorPosCallback(GLFWwindow* window, GLFWcursorposfun cbfun);
//    extern GLFWcursorenterfun glfwSetCursorEnterCallback(GLFWwindow* window, GLFWcursorenterfun cbfun);
//    extern GLFWscrollfun glfwSetScrollCallback(GLFWwindow* window, GLFWscrollfun cbfun);
//    extern GLFWdropfun glfwSetDropCallback(GLFWwindow* window, GLFWdropfun cbfun);
//    extern int glfwJoystickPresent(int joy);
//    extern const float* glfwGetJoystickAxes(int joy, int* count);
//    extern const unsigned char* glfwGetJoystickButtons(int joy, int* count);
//    extern const char* glfwGetJoystickName(int joy);
//    extern void glfwSetClipboardString(GLFWwindow* window, const char* string);
//    extern const char* glfwGetClipboardString(GLFWwindow* window);
//    extern double glfwGetTime(void);
//    extern void glfwSetTime(double time);
//    extern void glfwMakeContextCurrent(GLFWwindow* window);
//    extern GLFWwindow* glfwGetCurrentContext(void);
//    extern void glfwSwapBuffers(GLFWwindow* window);
//    extern void glfwSwapInterval(int interval);
//    extern int glfwExtensionSupported(const char* extension);
//    extern GLFWglproc glfwGetProcAddress(const char* procname);

let init()          = glfwInit()
let terminate()     = glfwTerminate()
let getVersion()    =
    let mutable major = 0
    let mutable minor = 0
    let mutable rev   = 0
    glfwGetVersion(&major, &minor, &rev)
    major, minor, rev

let getVersionString()  = Marshal.PtrToStringAnsi(glfwGetVersionString())

let getMonitors() =
    let mutable count = 0
    let ret = glfwGetMonitors(&count)
    let nativePtrs = Array.init count (fun i -> IntPtr.Zero)

    Marshal.Copy(ret, nativePtrs, 0, count)

    nativePtrs
    |> Array.map(fun m -> Monitor(m))

let getPrimaryMonitor() = Monitor(glfwGetPrimaryMonitor())

let getMonitorPos(m: Monitor) =
    let mutable x, y = 0, 0
    glfwGetMonitorPos(m.Value, &x, &y)
    x, y

let getMonitorPhysicalSize (m: Monitor) =
    let mutable w, h = 0, 0
    glfwGetMonitorPhysicalSize(m.Value, &w, &h)
    w, h

let getMonitorName (m: Monitor) = Marshal.PtrToStringAnsi(glfwGetMonitorName m.Value)

let getVideoModes (m: Monitor) =
    let mutable count = 0
    let ret = glfwGetVideoModes(m.Value, &count)
    let vidModes = Array.init count (fun i -> VideoMode())

    let modeSize = Marshal.SizeOf(typeof<VideoMode>)

    for i in 0..count - 1 do
        vidModes.[i] <- unbox<VideoMode>(Marshal.PtrToStructure(IntPtr.Add(ret, i * modeSize), typeof<VideoMode>))

    vidModes

let getVideoMode (m: Monitor) =
    let ret =  glfwGetVideoMode m.Value
    unbox<VideoMode>(Marshal.PtrToStructure(ret, typeof<VideoMode>))

let setGamma(m: Monitor, g: float32) = glfwSetGamma(m.Value, g)


let getGammaramp (m: Monitor) =
    let ramp = unbox<GLFWgammaramp>(Marshal.PtrToStructure(glfwGetGammaRamp(m.Value), typeof<GLFWgammaramp>))
    let redArr = Array.init (int ramp.size) (fun _ -> 0s)
    Marshal.Copy(ramp.red, redArr, 0, int ramp.size)
    let greenArr = Array.init (int ramp.size) (fun _ -> 0s)
    Marshal.Copy(ramp.green, greenArr, 0, int ramp.size)
    let blueArr = Array.init (int ramp.size) (fun _ -> 0s)
    Marshal.Copy(ramp.blue, blueArr, 0, int ramp.size)

    let s2i x = if x < 0s then 65535 - int x else int x
    GammaRamp(redArr   |> Array.map s2i,
              greenArr |> Array.map s2i,
              blueArr  |> Array.map s2i)

let defaultWindowHint () = glfwDefaultWindowHints ()

let windowHint(wh: WindowHint, v: int) = glfwWindowHint(wh |> int, v)

