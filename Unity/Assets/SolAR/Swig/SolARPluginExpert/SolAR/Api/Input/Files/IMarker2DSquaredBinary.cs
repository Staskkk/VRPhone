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

    using XPCF.Api;
    using SolAR.Core;
    using SolAR.Datastructure;

public class IMarker2DSquaredBinary : IMarker2DSquared {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal IMarker2DSquaredBinary(global::System.IntPtr cPtr, bool cMemoryOwn) : base(solar_api_input_filesPINVOKE.IMarker2DSquaredBinary_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IMarker2DSquaredBinary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          solar_api_input_filesPINVOKE.delete_IMarker2DSquaredBinary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual SquaredBinaryPattern getPattern() {
    SquaredBinaryPattern ret = new SquaredBinaryPattern(solar_api_input_filesPINVOKE.IMarker2DSquaredBinary_getPattern(swigCPtr), true);
    if (solar_api_input_filesPINVOKE.SWIGPendingException.Pending) throw solar_api_input_filesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
