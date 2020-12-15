//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Api.Features {

    using XPCF.Api;
    using SolAR.Core;
    using SolAR.Datastructure;

public class IDescriptorMatcher : IComponentIntrospect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal IDescriptorMatcher(global::System.IntPtr cPtr, bool cMemoryOwn) : base(solar_api_featuresPINVOKE.IDescriptorMatcher_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IDescriptorMatcher obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          solar_api_featuresPINVOKE.delete_IDescriptorMatcher(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual IDescriptorMatcher.RetCode match(DescriptorBuffer descriptors1, DescriptorBuffer descriptors2, DescriptorMatchVector matches) {
    IDescriptorMatcher.RetCode ret = (IDescriptorMatcher.RetCode)solar_api_featuresPINVOKE.IDescriptorMatcher_match__SWIG_0(swigCPtr, DescriptorBuffer.getCPtr(descriptors1), DescriptorBuffer.getCPtr(descriptors2), DescriptorMatchVector.getCPtr(matches));
    if (solar_api_featuresPINVOKE.SWIGPendingException.Pending) throw solar_api_featuresPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual IDescriptorMatcher.RetCode match(DescriptorBuffer descriptors1, DescriptorBufferList descriptors2, DescriptorMatchVector matches) {
    IDescriptorMatcher.RetCode ret = (IDescriptorMatcher.RetCode)solar_api_featuresPINVOKE.IDescriptorMatcher_match__SWIG_1(swigCPtr, DescriptorBuffer.getCPtr(descriptors1), DescriptorBufferList.getCPtr(descriptors2), DescriptorMatchVector.getCPtr(matches));
    if (solar_api_featuresPINVOKE.SWIGPendingException.Pending) throw solar_api_featuresPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual IDescriptorMatcher.RetCode matchInRegion(Point2DfArray points2D, DescriptorBufferList descriptors, Frame frame, DescriptorMatchVector matches, float radius) {
    IDescriptorMatcher.RetCode ret = (IDescriptorMatcher.RetCode)solar_api_featuresPINVOKE.IDescriptorMatcher_matchInRegion(swigCPtr, Point2DfArray.getCPtr(points2D), DescriptorBufferList.getCPtr(descriptors), Frame.getCPtr(frame), DescriptorMatchVector.getCPtr(matches), radius);
    if (solar_api_featuresPINVOKE.SWIGPendingException.Pending) throw solar_api_featuresPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum RetCode {
    DESCRIPTORS_MATCHER_OK = 0,
    DESCRIPTORS_DONT_MATCH,
    DESCRIPTOR_TYPE_UNDEFINED,
    DESCRIPTOR_EMPTY
  }

}

}
