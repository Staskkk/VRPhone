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

public class IConfigurable : IComponentIntrospect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal IConfigurable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(xpcf_apiPINVOKE.IConfigurable_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IConfigurable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          xpcf_apiPINVOKE.delete_IConfigurable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual XPCFErrorCode configure(string filepath) {
    XPCFErrorCode ret = (XPCFErrorCode)xpcf_apiPINVOKE.IConfigurable_configure__SWIG_0(swigCPtr, filepath);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual XPCFErrorCode configure(string filepath, string xpath) {
    XPCFErrorCode ret = (XPCFErrorCode)xpcf_apiPINVOKE.IConfigurable_configure__SWIG_1(swigCPtr, filepath, xpath);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual XPCFErrorCode onConfigured() {
    XPCFErrorCode ret = (XPCFErrorCode)xpcf_apiPINVOKE.IConfigurable_onConfigured(swigCPtr);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual XPCFErrorCode serialize(string filepath, uint mode) {
    XPCFErrorCode ret = (XPCFErrorCode)xpcf_apiPINVOKE.IConfigurable_serialize(swigCPtr, filepath, mode);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasProperties() {
    bool ret = xpcf_apiPINVOKE.IConfigurable_hasProperties(swigCPtr);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual IProperty getProperty(string name) {
    global::System.IntPtr cPtr = xpcf_apiPINVOKE.IConfigurable_getProperty(swigCPtr, name);
    IProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new IProperty(cPtr, true);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual IPropertyMap getPropertyRootNode() {
    global::System.IntPtr cPtr = xpcf_apiPINVOKE.IConfigurable_getPropertyRootNode(swigCPtr);
    IPropertyMap ret = (cPtr == global::System.IntPtr.Zero) ? null : new IPropertyMap(cPtr, true);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual PropertyEnumerable getProperties() {
    PropertyEnumerable ret = new PropertyEnumerable(xpcf_apiPINVOKE.IConfigurable_getProperties(swigCPtr), false);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual PropertyEnumerator getPropertiesEnumerator() {
    global::System.IntPtr cPtr = xpcf_apiPINVOKE.IConfigurable_getPropertiesEnumerator(swigCPtr);
    PropertyEnumerator ret = (cPtr == global::System.IntPtr.Zero) ? null : new PropertyEnumerator(cPtr, true);
    if (xpcf_apiPINVOKE.SWIGPendingException.Pending) throw xpcf_apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
