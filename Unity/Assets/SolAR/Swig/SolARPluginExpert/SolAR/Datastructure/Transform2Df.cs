//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SolAR.Datastructure {

    //using XPCF.Core;
    using SolAR.Core;

public class Transform2Df : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Transform2Df(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Transform2Df obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Transform2Df() {
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
          solar_datastructurePINVOKE.delete_Transform2Df(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Transform2Df() : this(solar_datastructurePINVOKE.new_Transform2Df(), true) {
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public static Transform2Df Identity() {
    Transform2Df ret = new Transform2Df(solar_datastructurePINVOKE.Transform2Df_Identity(), true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix2x2f rotation() {
    Matrix2x2f ret = new Matrix2x2f(solar_datastructurePINVOKE.Transform2Df_rotation(swigCPtr), true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2f translation() {
    Vector2f ret = new Vector2f(solar_datastructurePINVOKE.Transform2Df_translation(swigCPtr), true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}