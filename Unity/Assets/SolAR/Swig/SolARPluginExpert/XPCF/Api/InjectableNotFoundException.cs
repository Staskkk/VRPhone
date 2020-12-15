//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace XPCF.Api {

    using XPCF.Core;
    using XPCF.Collection;
    using XPCF.Properties;
    using XPCF.Traits;

public class InjectableNotFoundException : InjectionException {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal InjectableNotFoundException(global::System.IntPtr cPtr, bool cMemoryOwn) : base(xpcf_apiPINVOKE.InjectableNotFoundException_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InjectableNotFoundException obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xpcf_apiPINVOKE.delete_InjectableNotFoundException(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public InjectableNotFoundException(SWIGTYPE_p_boost__shared_ptrT_org__bcom__xpcf__InjectableMetadata_t injectableInfo) : this(xpcf_apiPINVOKE.new_InjectableNotFoundException__SWIG_0(SWIGTYPE_p_boost__shared_ptrT_org__bcom__xpcf__InjectableMetadata_t.getCPtr(injectableInfo)), true) {
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
  }

  public InjectableNotFoundException(string what) : this(xpcf_apiPINVOKE.new_InjectableNotFoundException__SWIG_1(what), true) {
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
