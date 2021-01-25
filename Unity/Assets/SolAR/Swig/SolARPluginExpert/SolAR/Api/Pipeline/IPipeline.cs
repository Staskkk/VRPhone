//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Pipeline {

    using XPCF.Api;
    using SolAR.Core;
    using SolAR.Datastructure;
    using SolAR.Api.Sink;
    using SolAR.Api.Source;

public class IPipeline : IComponentIntrospect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal IPipeline(global::System.IntPtr cPtr, bool cMemoryOwn) : base(solar_api_pipelinePINVOKE.IPipeline_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IPipeline obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          solar_api_pipelinePINVOKE.delete_IPipeline(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual FrameworkReturnCode init(IComponentManager componentManager) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_pipelinePINVOKE.IPipeline_init(swigCPtr, IComponentManager.getCPtr(componentManager));
    if (solar_api_pipelinePINVOKE.SWIGPendingException.Pending) throw solar_api_pipelinePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual CameraParameters getCameraParameters() {
    CameraParameters ret = new CameraParameters(solar_api_pipelinePINVOKE.IPipeline_getCameraParameters(swigCPtr), true);
    if (solar_api_pipelinePINVOKE.SWIGPendingException.Pending) throw solar_api_pipelinePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FrameworkReturnCode start(global::System.IntPtr textureHandle) {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_pipelinePINVOKE.IPipeline_start(swigCPtr, textureHandle);
    if (solar_api_pipelinePINVOKE.SWIGPendingException.Pending) throw solar_api_pipelinePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FrameworkReturnCode stop() {
    FrameworkReturnCode ret = (FrameworkReturnCode)solar_api_pipelinePINVOKE.IPipeline_stop(swigCPtr);
    if (solar_api_pipelinePINVOKE.SWIGPendingException.Pending) throw solar_api_pipelinePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SinkReturnCode update(Transform3Df pose) {
    SinkReturnCode ret = (SinkReturnCode)solar_api_pipelinePINVOKE.IPipeline_update(swigCPtr, Transform3Df.getCPtr(pose));
    if (solar_api_pipelinePINVOKE.SWIGPendingException.Pending) throw solar_api_pipelinePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SourceReturnCode loadSourceImage(global::System.IntPtr sourceTextureHandle, int width, int height) {
    SourceReturnCode ret = (SourceReturnCode)solar_api_pipelinePINVOKE.IPipeline_loadSourceImage(swigCPtr, sourceTextureHandle, width, height);
    if (solar_api_pipelinePINVOKE.SWIGPendingException.Pending) throw solar_api_pipelinePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}