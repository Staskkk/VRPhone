//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Reloc {

    using XPCF.Api;
    using SolAR.Core;
    using SolAR.Datastructure;

public class IRelocalizer : IComponentIntrospect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal IRelocalizer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(solar_api_relocPINVOKE.IRelocalizer_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IRelocalizer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          solar_api_relocPINVOKE.delete_IRelocalizer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual FrameworkReturnCode addKeyframe(Keyframe keyframe) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_relocPINVOKE.IRelocalizer_addKeyframe(swigCPtr, Keyframe.getCPtr(keyframe));
    if (solar_api_relocPINVOKE.SWIGPendingException.Pending) throw solar_api_relocPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FrameworkReturnCode relocalize(Frame frame, Transform3Df pose) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_relocPINVOKE.IRelocalizer_relocalize(swigCPtr, Frame.getCPtr(frame), Transform3Df.getCPtr(pose));
    if (solar_api_relocPINVOKE.SWIGPendingException.Pending) throw solar_api_relocPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
