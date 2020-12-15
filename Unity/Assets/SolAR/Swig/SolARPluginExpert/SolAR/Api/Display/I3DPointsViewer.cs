//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Display {

    using XPCF.Api;
    using SolAR.Core;
    using SolAR.Datastructure;

public class I3DPointsViewer : IComponentIntrospect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal I3DPointsViewer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(solar_api_displayPINVOKE.I3DPointsViewer_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(I3DPointsViewer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          solar_api_displayPINVOKE.delete_I3DPointsViewer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual FrameworkReturnCode display(CloudPointVector points, Transform3Df pose, Transform3DfList keyframePoses, Transform3DfList framePoses, CloudPointVector points2, Transform3DfList keyframePoses2) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_displayPINVOKE.I3DPointsViewer_display__SWIG_0(swigCPtr, CloudPointVector.getCPtr(points), Transform3Df.getCPtr(pose), Transform3DfList.getCPtr(keyframePoses), Transform3DfList.getCPtr(framePoses), CloudPointVector.getCPtr(points2), Transform3DfList.getCPtr(keyframePoses2));
    if (solar_api_displayPINVOKE.SWIGPendingException.Pending) throw solar_api_displayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FrameworkReturnCode display(CloudPointVector points, Transform3Df pose, Transform3DfList keyframePoses, Transform3DfList framePoses, CloudPointVector points2) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_displayPINVOKE.I3DPointsViewer_display__SWIG_1(swigCPtr, CloudPointVector.getCPtr(points), Transform3Df.getCPtr(pose), Transform3DfList.getCPtr(keyframePoses), Transform3DfList.getCPtr(framePoses), CloudPointVector.getCPtr(points2));
    if (solar_api_displayPINVOKE.SWIGPendingException.Pending) throw solar_api_displayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FrameworkReturnCode display(CloudPointVector points, Transform3Df pose, Transform3DfList keyframePoses, Transform3DfList framePoses) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_displayPINVOKE.I3DPointsViewer_display__SWIG_2(swigCPtr, CloudPointVector.getCPtr(points), Transform3Df.getCPtr(pose), Transform3DfList.getCPtr(keyframePoses), Transform3DfList.getCPtr(framePoses));
    if (solar_api_displayPINVOKE.SWIGPendingException.Pending) throw solar_api_displayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FrameworkReturnCode display(CloudPointVector points, Transform3Df pose, Transform3DfList keyframePoses) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_displayPINVOKE.I3DPointsViewer_display__SWIG_3(swigCPtr, CloudPointVector.getCPtr(points), Transform3Df.getCPtr(pose), Transform3DfList.getCPtr(keyframePoses));
    if (solar_api_displayPINVOKE.SWIGPendingException.Pending) throw solar_api_displayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FrameworkReturnCode display(CloudPointVector points, Transform3Df pose) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_displayPINVOKE.I3DPointsViewer_display__SWIG_4(swigCPtr, CloudPointVector.getCPtr(points), Transform3Df.getCPtr(pose));
    if (solar_api_displayPINVOKE.SWIGPendingException.Pending) throw solar_api_displayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
