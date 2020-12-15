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

public class IComponentIntrospect : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal IComponentIntrospect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IComponentIntrospect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IComponentIntrospect() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          xpcf_apiPINVOKE.delete_IComponentIntrospect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual uint getNbInterfaces() {
    uint ret = xpcf_apiPINVOKE.IComponentIntrospect_getNbInterfaces(swigCPtr);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual UUIDEnumerable getInterfaces() {
    UUIDEnumerable ret = new UUIDEnumerable(xpcf_apiPINVOKE.IComponentIntrospect_getInterfaces(swigCPtr), false);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool implements(UUID interfaceUUID) {
    bool ret = xpcf_apiPINVOKE.IComponentIntrospect_implements(swigCPtr, UUID.getCPtr(interfaceUUID));
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string getDescription(UUID interfaceUUID) {
    string ret = xpcf_apiPINVOKE.IComponentIntrospect_getDescription(swigCPtr, UUID.getCPtr(interfaceUUID));
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IComponentIntrospect queryInterface(UUID interfaceUUID) {
    global::System.IntPtr cPtr = xpcf_apiPINVOKE.IComponentIntrospect_queryInterface(swigCPtr, UUID.getCPtr(interfaceUUID));
    IComponentIntrospect ret = (cPtr == global::System.IntPtr.Zero) ? null : new IComponentIntrospect(cPtr, true);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
