//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Tracking {

class solar_api_trackingPINVOKE {

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

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterExceptionCallbacks_solar_api_tracking")]
    public static extern void SWIGRegisterExceptionCallbacks_solar_api_tracking(
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

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_solar_api_tracking")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_solar_api_tracking(
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
      SWIGRegisterExceptionCallbacks_solar_api_tracking(
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

      SWIGRegisterExceptionCallbacksArgument_solar_api_tracking(
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

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterStringCallback_solar_api_tracking")]
    public static extern void SWIGRegisterStringCallback_solar_api_tracking(SWIGStringDelegate stringDelegate);

    [AOT.MonoPInvokeCallback(typeof(SWIGStringDelegate))] static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_solar_api_tracking(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static solar_api_trackingPINVOKE() {
  }


  protected class SWIGWStringHelper {

    [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]
    public delegate string SWIGWStringDelegate(global::System.IntPtr message);
    static SWIGWStringDelegate wstringDelegate = new SWIGWStringDelegate(CreateWString);

    [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="SWIGRegisterWStringCallback_solar_api_tracking")]
    public static extern void SWIGRegisterWStringCallback_solar_api_tracking(SWIGWStringDelegate wstringDelegate);

    static string CreateWString([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]global::System.IntPtr cString) {
      return global::System.Runtime.InteropServices.Marshal.PtrToStringUni(cString);
    }

    static SWIGWStringHelper() {
      SWIGRegisterWStringCallback_solar_api_tracking(wstringDelegate);
    }
  }

  static protected SWIGWStringHelper swigWStringHelper = new SWIGWStringHelper();


  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Clear___")]
  public static extern void UCharList_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Add___")]
  public static extern void UCharList_Add(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_size___")]
  public static extern uint UCharList_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_capacity___")]
  public static extern uint UCharList_capacity(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_reserve___")]
  public static extern void UCharList_reserve(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_new_UCharList__SWIG_0___")]
  public static extern global::System.IntPtr new_UCharList__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_new_UCharList__SWIG_1___")]
  public static extern global::System.IntPtr new_UCharList__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_new_UCharList__SWIG_2___")]
  public static extern global::System.IntPtr new_UCharList__SWIG_2(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_getitemcopy___")]
  public static extern byte UCharList_getitemcopy(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_getitem___")]
  public static extern byte UCharList_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_setitem___")]
  public static extern void UCharList_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, byte jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_AddRange___")]
  public static extern void UCharList_AddRange(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_GetRange___")]
  public static extern global::System.IntPtr UCharList_GetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Insert___")]
  public static extern void UCharList_Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, byte jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_InsertRange___")]
  public static extern void UCharList_InsertRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_RemoveAt___")]
  public static extern void UCharList_RemoveAt(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_RemoveRange___")]
  public static extern void UCharList_RemoveRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Repeat___")]
  public static extern global::System.IntPtr UCharList_Repeat(byte jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Reverse__SWIG_0___")]
  public static extern void UCharList_Reverse__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Reverse__SWIG_1___")]
  public static extern void UCharList_Reverse__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_SetRange___")]
  public static extern void UCharList_SetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Contains___")]
  public static extern bool UCharList_Contains(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_IndexOf___")]
  public static extern int UCharList_IndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_LastIndexOf___")]
  public static extern int UCharList_LastIndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_UCharList_Remove___")]
  public static extern bool UCharList_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_delete_UCharList___")]
  public static extern void delete_UCharList(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Clear___")]
  public static extern void FloatList_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Add___")]
  public static extern void FloatList_Add(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_size___")]
  public static extern uint FloatList_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_capacity___")]
  public static extern uint FloatList_capacity(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_reserve___")]
  public static extern void FloatList_reserve(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_new_FloatList__SWIG_0___")]
  public static extern global::System.IntPtr new_FloatList__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_new_FloatList__SWIG_1___")]
  public static extern global::System.IntPtr new_FloatList__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_new_FloatList__SWIG_2___")]
  public static extern global::System.IntPtr new_FloatList__SWIG_2(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_getitemcopy___")]
  public static extern float FloatList_getitemcopy(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_getitem___")]
  public static extern float FloatList_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_setitem___")]
  public static extern void FloatList_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, float jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_AddRange___")]
  public static extern void FloatList_AddRange(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_GetRange___")]
  public static extern global::System.IntPtr FloatList_GetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Insert___")]
  public static extern void FloatList_Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, float jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_InsertRange___")]
  public static extern void FloatList_InsertRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_RemoveAt___")]
  public static extern void FloatList_RemoveAt(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_RemoveRange___")]
  public static extern void FloatList_RemoveRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Repeat___")]
  public static extern global::System.IntPtr FloatList_Repeat(float jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Reverse__SWIG_0___")]
  public static extern void FloatList_Reverse__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Reverse__SWIG_1___")]
  public static extern void FloatList_Reverse__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_SetRange___")]
  public static extern void FloatList_SetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Contains___")]
  public static extern bool FloatList_Contains(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_IndexOf___")]
  public static extern int FloatList_IndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_LastIndexOf___")]
  public static extern int FloatList_LastIndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_FloatList_Remove___")]
  public static extern bool FloatList_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_delete_FloatList___")]
  public static extern void delete_FloatList(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_delete_IOpticalFlowEstimator___")]
  public static extern void delete_IOpticalFlowEstimator(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_IOpticalFlowEstimator_estimate__SWIG_0___")]
  public static extern int IOpticalFlowEstimator_estimate__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3, global::System.Runtime.InteropServices.HandleRef jarg4, global::System.Runtime.InteropServices.HandleRef jarg5, global::System.Runtime.InteropServices.HandleRef jarg6, global::System.Runtime.InteropServices.HandleRef jarg7);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_IOpticalFlowEstimator_estimate__SWIG_1___")]
  public static extern int IOpticalFlowEstimator_estimate__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3, global::System.Runtime.InteropServices.HandleRef jarg4, global::System.Runtime.InteropServices.HandleRef jarg5, global::System.Runtime.InteropServices.HandleRef jarg6, global::System.Runtime.InteropServices.HandleRef jarg7);

  [global::System.Runtime.InteropServices.DllImport("SolARWrapper", EntryPoint="CSharp_SolARfApifTracking_IOpticalFlowEstimator_SWIGSmartPtrUpcast___")]
  public static extern global::System.IntPtr IOpticalFlowEstimator_SWIGSmartPtrUpcast(global::System.IntPtr jarg1);
}

}
