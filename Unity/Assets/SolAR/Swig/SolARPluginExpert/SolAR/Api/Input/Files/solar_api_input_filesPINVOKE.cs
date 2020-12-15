//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Input.Files {

class solar_api_input_filesPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterExceptionCallbacks_solar_api_input_files")]
    public static extern void SWIGRegisterExceptionCallbacks_solar_api_input_files(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_solar_api_input_files")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_solar_api_input_files(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))] static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_solar_api_input_files(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_solar_api_input_files(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;
    private static global::System.Object exceptionsLock = null;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(exceptionsLock) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(exceptionsLock) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }

    static SWIGPendingException() {
      exceptionsLock = new global::System.Object();
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterStringCallback_solar_api_input_files")]
    public static extern void SWIGRegisterStringCallback_solar_api_input_files(SWIGStringDelegate stringDelegate);

    [AOT.MonoPInvokeCallback(typeof(SWIGStringDelegate))] static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_solar_api_input_files(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static solar_api_input_filesPINVOKE() {
  }


  protected class SWIGWStringHelper {

    [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]
    public delegate string SWIGWStringDelegate(global::System.IntPtr message);
    static SWIGWStringDelegate wstringDelegate = new SWIGWStringDelegate(CreateWString);

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterWStringCallback_solar_api_input_files")]
    public static extern void SWIGRegisterWStringCallback_solar_api_input_files(SWIGWStringDelegate wstringDelegate);

    static string CreateWString([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]global::System.IntPtr cString) {
      return global::System.Runtime.InteropServices.Marshal.PtrToStringUni(cString);
    }

    static SWIGWStringHelper() {
      SWIGRegisterWStringCallback_solar_api_input_files(wstringDelegate);
    }
  }

  static protected SWIGWStringHelper swigWStringHelper = new SWIGWStringHelper();


  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_delete_IMarker___")]
  public static extern void delete_IMarker(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker_loadMarker___")]
  public static extern int IMarker_loadMarker(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_delete_IMarker2DSquared___")]
  public static extern void delete_IMarker2DSquared(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquared_setSize___")]
  public static extern void IMarker2DSquared_setSize(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2, float jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquared_getWidth___")]
  public static extern float IMarker2DSquared_getWidth(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquared_getHeight___")]
  public static extern float IMarker2DSquared_getHeight(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquared_getSize___")]
  public static extern global::System.IntPtr IMarker2DSquared_getSize(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquared_getImageCorners___")]
  public static extern int IMarker2DSquared_getImageCorners(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquared_getWorldCorners___")]
  public static extern int IMarker2DSquared_getWorldCorners(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_delete_IMarker2DSquaredBinary___")]
  public static extern void delete_IMarker2DSquaredBinary(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquaredBinary_getPattern___")]
  public static extern global::System.IntPtr IMarker2DSquaredBinary_getPattern(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_delete_IMarker2DNaturalImage___")]
  public static extern void delete_IMarker2DNaturalImage(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DNaturalImage_getImage___")]
  public static extern int IMarker2DNaturalImage_getImage(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker_SWIGSmartPtrUpcast___")]
  public static extern global::System.IntPtr IMarker_SWIGSmartPtrUpcast(global::System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquared_SWIGSmartPtrUpcast___")]
  public static extern global::System.IntPtr IMarker2DSquared_SWIGSmartPtrUpcast(global::System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DSquaredBinary_SWIGSmartPtrUpcast___")]
  public static extern global::System.IntPtr IMarker2DSquaredBinary_SWIGSmartPtrUpcast(global::System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifInputfFiles_IMarker2DNaturalImage_SWIGSmartPtrUpcast___")]
  public static extern global::System.IntPtr IMarker2DNaturalImage_SWIGSmartPtrUpcast(global::System.IntPtr jarg1);
}

}
