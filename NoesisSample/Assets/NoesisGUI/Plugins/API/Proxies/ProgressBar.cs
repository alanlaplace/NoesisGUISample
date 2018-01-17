//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class ProgressBar : RangeBase {
  internal new static ProgressBar CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ProgressBar(cPtr, cMemoryOwn);
  }

  internal ProgressBar(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ProgressBar obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ProgressBar() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(ProgressBar).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ProgressBar();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsIndeterminateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ProgressBar_IsIndeterminateProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty OrientationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ProgressBar_OrientationProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsIndeterminate {
    set {
      NoesisGUI_PINVOKE.ProgressBar_IsIndeterminate_set(swigCPtr, value);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ProgressBar_IsIndeterminate_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Orientation Orientation {
    set {
      NoesisGUI_PINVOKE.ProgressBar_Orientation_set(swigCPtr, (int)value);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      Orientation ret = (Orientation)NoesisGUI_PINVOKE.ProgressBar_Orientation_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.ProgressBar_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }


  internal new static IntPtr Extend(string typeName) {
    IntPtr nativeType = NoesisGUI_PINVOKE.Extend_ProgressBar(Marshal.StringToHGlobalAnsi(typeName));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return nativeType;
  }
}

}
