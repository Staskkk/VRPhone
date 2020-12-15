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

public class KeypointArray : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<Keypoint>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal KeypointArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KeypointArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KeypointArray() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          solar_datastructurePINVOKE.delete_KeypointArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public KeypointArray(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Keypoint element in c) {
      this.Add(element);
    }
  }

  public KeypointArray(global::System.Collections.Generic.IEnumerable<Keypoint> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Keypoint element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Keypoint this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(Keypoint[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Keypoint[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Keypoint[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public Keypoint[] ToArray() {
    Keypoint[] array = new Keypoint[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<Keypoint> global::System.Collections.Generic.IEnumerable<Keypoint>.GetEnumerator() {
    return new KeypointArrayEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new KeypointArrayEnumerator(this);
  }

  public KeypointArrayEnumerator GetEnumerator() {
    return new KeypointArrayEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class KeypointArrayEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Keypoint>
  {
    private KeypointArray collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public KeypointArrayEnumerator(KeypointArray collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Keypoint Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Keypoint)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    solar_datastructurePINVOKE.KeypointArray_Clear(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(Keypoint x) {
    solar_datastructurePINVOKE.KeypointArray_Add(swigCPtr, Keypoint.getCPtr(x));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = solar_datastructurePINVOKE.KeypointArray_size(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = solar_datastructurePINVOKE.KeypointArray_capacity(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    solar_datastructurePINVOKE.KeypointArray_reserve(swigCPtr, n);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public KeypointArray() : this(solar_datastructurePINVOKE.new_KeypointArray__SWIG_0(), true) {
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public KeypointArray(KeypointArray other) : this(solar_datastructurePINVOKE.new_KeypointArray__SWIG_1(KeypointArray.getCPtr(other)), true) {
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public KeypointArray(int capacity) : this(solar_datastructurePINVOKE.new_KeypointArray__SWIG_2(capacity), true) {
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  private Keypoint getitemcopy(int index) {
    Keypoint ret = new Keypoint(solar_datastructurePINVOKE.KeypointArray_getitemcopy(swigCPtr, index), true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Keypoint getitem(int index) {
    Keypoint ret = new Keypoint(solar_datastructurePINVOKE.KeypointArray_getitem(swigCPtr, index), true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Keypoint val) {
    solar_datastructurePINVOKE.KeypointArray_setitem(swigCPtr, index, Keypoint.getCPtr(val));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(KeypointArray values) {
    solar_datastructurePINVOKE.KeypointArray_AddRange(swigCPtr, KeypointArray.getCPtr(values));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public KeypointArray GetRange(int index, int count) {
    global::System.IntPtr cPtr = solar_datastructurePINVOKE.KeypointArray_GetRange(swigCPtr, index, count);
    KeypointArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new KeypointArray(cPtr, true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Keypoint x) {
    solar_datastructurePINVOKE.KeypointArray_Insert(swigCPtr, index, Keypoint.getCPtr(x));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, KeypointArray values) {
    solar_datastructurePINVOKE.KeypointArray_InsertRange(swigCPtr, index, KeypointArray.getCPtr(values));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    solar_datastructurePINVOKE.KeypointArray_RemoveAt(swigCPtr, index);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    solar_datastructurePINVOKE.KeypointArray_RemoveRange(swigCPtr, index, count);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public static KeypointArray Repeat(Keypoint value, int count) {
    global::System.IntPtr cPtr = solar_datastructurePINVOKE.KeypointArray_Repeat(Keypoint.getCPtr(value), count);
    KeypointArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new KeypointArray(cPtr, true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    solar_datastructurePINVOKE.KeypointArray_Reverse__SWIG_0(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    solar_datastructurePINVOKE.KeypointArray_Reverse__SWIG_1(swigCPtr, index, count);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, KeypointArray values) {
    solar_datastructurePINVOKE.KeypointArray_SetRange(swigCPtr, index, KeypointArray.getCPtr(values));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
