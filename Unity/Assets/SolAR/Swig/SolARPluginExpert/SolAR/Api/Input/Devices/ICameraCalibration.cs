//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Input.Devices {

    using XPCF.Api;
    using SolAR.Core;
    using SolAR.Datastructure;

public class ICameraCalibration : IComponentIntrospect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ICameraCalibration(global::System.IntPtr cPtr, bool cMemoryOwn) : base(solar_api_input_devicesPINVOKE.ICameraCalibration_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ICameraCalibration obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          solar_api_input_devicesPINVOKE.delete_ICameraCalibration(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual bool calibrate(string inputVideo, string output) {
    bool ret = solar_api_input_devicesPINVOKE.ICameraCalibration_calibrate__SWIG_0(swigCPtr, inputVideo, output);
    if (solar_api_input_devicesPINVOKE.SWIGPendingException.Pending) throw solar_api_input_devicesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool calibrate(int camera_id, string output) {
    bool ret = solar_api_input_devicesPINVOKE.ICameraCalibration_calibrate__SWIG_1(swigCPtr, camera_id, output);
    if (solar_api_input_devicesPINVOKE.SWIGPendingException.Pending) throw solar_api_input_devicesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool setParameters(string config_file) {
    bool ret = solar_api_input_devicesPINVOKE.ICameraCalibration_setParameters(swigCPtr, config_file);
    if (solar_api_input_devicesPINVOKE.SWIGPendingException.Pending) throw solar_api_input_devicesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}