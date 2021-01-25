//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace XPCF.Collection {

	using System.Collections;
	using System.Collections.Generic;
	using XPCF.Core;
	using XPCF.Api;
	using XPCF.Properties;

public class ModuleMetadataEnumerator : global::System.IDisposable, IEnumerator<ModuleMetadata> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ModuleMetadataEnumerator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ModuleMetadataEnumerator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ModuleMetadataEnumerator() {
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
          xpcf_collectionPINVOKE.delete_ModuleMetadataEnumerator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual bool MoveNext() {
    bool ret = xpcf_collectionPINVOKE.ModuleMetadataEnumerator_MoveNext(swigCPtr);
    if (xpcf_collectionPINVOKE.SWIGPendingException.Pending) throw xpcf_collectionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Reset() {
    xpcf_collectionPINVOKE.ModuleMetadataEnumerator_Reset(swigCPtr);
    if (xpcf_collectionPINVOKE.SWIGPendingException.Pending) throw xpcf_collectionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ModuleMetadata current() {
    global::System.IntPtr cPtr = xpcf_collectionPINVOKE.ModuleMetadataEnumerator_current(swigCPtr);
    ModuleMetadata ret = (cPtr == global::System.IntPtr.Zero) ? null : new ModuleMetadata(cPtr, true);
    if (xpcf_collectionPINVOKE.SWIGPendingException.Pending) throw xpcf_collectionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool endReached() {
    bool ret = xpcf_collectionPINVOKE.ModuleMetadataEnumerator_endReached(swigCPtr);
    if (xpcf_collectionPINVOKE.SWIGPendingException.Pending) throw xpcf_collectionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

		public ModuleMetadata Current { get { return current(); } }
		object IEnumerator.Current { get { return current(); } }
	
}

}