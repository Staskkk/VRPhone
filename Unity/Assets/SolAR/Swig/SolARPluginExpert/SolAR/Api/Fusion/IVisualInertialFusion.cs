//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Fusion {

    using XPCF.Api;
    using SolAR.Core;
    using SolAR.Datastructure;

public class IVisualInertialFusion : IComponentIntrospect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal IVisualInertialFusion(global::System.IntPtr cPtr, bool cMemoryOwn) : base(solar_api_fusionPINVOKE.IVisualInertialFusion_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IVisualInertialFusion obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          solar_api_fusionPINVOKE.delete_IVisualInertialFusion(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void init(VisionData initialVisionData) {
    solar_api_fusionPINVOKE.IVisualInertialFusion_init(swigCPtr, VisionData.getCPtr(initialVisionData));
    if (solar_api_fusionPINVOKE.SWIGPendingException.Pending) throw solar_api_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addInertialData(InertialData inertialData) {
    solar_api_fusionPINVOKE.IVisualInertialFusion_addInertialData(swigCPtr, InertialData.getCPtr(inertialData));
    if (solar_api_fusionPINVOKE.SWIGPendingException.Pending) throw solar_api_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addVisionData(VisionData visionData) {
    solar_api_fusionPINVOKE.IVisualInertialFusion_addVisionData(swigCPtr, VisionData.getCPtr(visionData));
    if (solar_api_fusionPINVOKE.SWIGPendingException.Pending) throw solar_api_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual FrameworkReturnCode process(Transform3Df outputData) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_fusionPINVOKE.IVisualInertialFusion_process(swigCPtr, Transform3Df.getCPtr(outputData));
    if (solar_api_fusionPINVOKE.SWIGPendingException.Pending) throw solar_api_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}