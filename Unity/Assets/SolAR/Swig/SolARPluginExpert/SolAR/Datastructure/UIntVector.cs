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

public class UIntVector : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<uint>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UIntVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UIntVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UIntVector() {
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
          solar_datastructurePINVOKE.delete_UIntVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public UIntVector(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (uint element in c) {
      this.Add(element);
    }
  }

  public UIntVector(global::System.Collections.Generic.IEnumerable<uint> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (uint element in c) {
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

  public uint this[int index]  {
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

  public void CopyTo(uint[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(uint[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, uint[] array, int arrayIndex, int count)
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

  public uint[] ToArray() {
    uint[] array = new uint[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<uint> global::System.Collections.Generic.IEnumerable<uint>.GetEnumerator() {
    return new UIntVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new UIntVectorEnumerator(this);
  }

  public UIntVectorEnumerator GetEnumerator() {
    return new UIntVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UIntVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<uint>
  {
    private UIntVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UIntVectorEnumerator(UIntVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public uint Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (uint)currentObject;
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
    solar_datastructurePINVOKE.UIntVector_Clear(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(uint x) {
    solar_datastructurePINVOKE.UIntVector_Add(swigCPtr, x);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = solar_datastructurePINVOKE.UIntVector_size(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = solar_datastructurePINVOKE.UIntVector_capacity(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    solar_datastructurePINVOKE.UIntVector_reserve(swigCPtr, n);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public UIntVector() : this(solar_datastructurePINVOKE.new_UIntVector__SWIG_0(), true) {
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public UIntVector(UIntVector other) : this(solar_datastructurePINVOKE.new_UIntVector__SWIG_1(UIntVector.getCPtr(other)), true) {
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public UIntVector(int capacity) : this(solar_datastructurePINVOKE.new_UIntVector__SWIG_2(capacity), true) {
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint getitemcopy(int index) {
    uint ret = solar_datastructurePINVOKE.UIntVector_getitemcopy(swigCPtr, index);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint getitem(int index) {
    uint ret = solar_datastructurePINVOKE.UIntVector_getitem(swigCPtr, index);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, uint val) {
    solar_datastructurePINVOKE.UIntVector_setitem(swigCPtr, index, val);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(UIntVector values) {
    solar_datastructurePINVOKE.UIntVector_AddRange(swigCPtr, UIntVector.getCPtr(values));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public UIntVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = solar_datastructurePINVOKE.UIntVector_GetRange(swigCPtr, index, count);
    UIntVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new UIntVector(cPtr, true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, uint x) {
    solar_datastructurePINVOKE.UIntVector_Insert(swigCPtr, index, x);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, UIntVector values) {
    solar_datastructurePINVOKE.UIntVector_InsertRange(swigCPtr, index, UIntVector.getCPtr(values));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    solar_datastructurePINVOKE.UIntVector_RemoveAt(swigCPtr, index);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    solar_datastructurePINVOKE.UIntVector_RemoveRange(swigCPtr, index, count);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public static UIntVector Repeat(uint value, int count) {
    global::System.IntPtr cPtr = solar_datastructurePINVOKE.UIntVector_Repeat(value, count);
    UIntVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new UIntVector(cPtr, true);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    solar_datastructurePINVOKE.UIntVector_Reverse__SWIG_0(swigCPtr);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    solar_datastructurePINVOKE.UIntVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, UIntVector values) {
    solar_datastructurePINVOKE.UIntVector_SetRange(swigCPtr, index, UIntVector.getCPtr(values));
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(uint value) {
    bool ret = solar_datastructurePINVOKE.UIntVector_Contains(swigCPtr, value);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(uint value) {
    int ret = solar_datastructurePINVOKE.UIntVector_IndexOf(swigCPtr, value);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(uint value) {
    int ret = solar_datastructurePINVOKE.UIntVector_LastIndexOf(swigCPtr, value);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(uint value) {
    bool ret = solar_datastructurePINVOKE.UIntVector_Remove(swigCPtr, value);
    if (solar_datastructurePINVOKE.SWIGPendingException.Pending) throw solar_datastructurePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}