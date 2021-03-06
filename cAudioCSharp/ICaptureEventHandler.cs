/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace cAudio {

using System;
using System.Runtime.InteropServices;

public class ICaptureEventHandler : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ICaptureEventHandler(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ICaptureEventHandler obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ICaptureEventHandler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cAudioCSharpWrapperPINVOKE.delete_ICaptureEventHandler(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void onInit() {
    cAudioCSharpWrapperPINVOKE.ICaptureEventHandler_onInit(swigCPtr);
  }

  public virtual void onUpdate() {
    cAudioCSharpWrapperPINVOKE.ICaptureEventHandler_onUpdate(swigCPtr);
  }

  public virtual void onRelease() {
    cAudioCSharpWrapperPINVOKE.ICaptureEventHandler_onRelease(swigCPtr);
  }

  public virtual void onBeginCapture() {
    cAudioCSharpWrapperPINVOKE.ICaptureEventHandler_onBeginCapture(swigCPtr);
  }

  public virtual void onEndCapture() {
    cAudioCSharpWrapperPINVOKE.ICaptureEventHandler_onEndCapture(swigCPtr);
  }

  public virtual void onUserRequestBuffer() {
    cAudioCSharpWrapperPINVOKE.ICaptureEventHandler_onUserRequestBuffer(swigCPtr);
  }

  public ICaptureEventHandler() : this(cAudioCSharpWrapperPINVOKE.new_ICaptureEventHandler(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onInit", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateICaptureEventHandler_0(SwigDirectoronInit);
    if (SwigDerivedClassHasMethod("onUpdate", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateICaptureEventHandler_1(SwigDirectoronUpdate);
    if (SwigDerivedClassHasMethod("onRelease", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateICaptureEventHandler_2(SwigDirectoronRelease);
    if (SwigDerivedClassHasMethod("onBeginCapture", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateICaptureEventHandler_3(SwigDirectoronBeginCapture);
    if (SwigDerivedClassHasMethod("onEndCapture", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateICaptureEventHandler_4(SwigDirectoronEndCapture);
    if (SwigDerivedClassHasMethod("onUserRequestBuffer", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateICaptureEventHandler_5(SwigDirectoronUserRequestBuffer);
    cAudioCSharpWrapperPINVOKE.ICaptureEventHandler_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ICaptureEventHandler));
    return hasDerivedMethod;
  }

  private void SwigDirectoronInit() {
    onInit();
  }

  private void SwigDirectoronUpdate() {
    onUpdate();
  }

  private void SwigDirectoronRelease() {
    onRelease();
  }

  private void SwigDirectoronBeginCapture() {
    onBeginCapture();
  }

  private void SwigDirectoronEndCapture() {
    onEndCapture();
  }

  private void SwigDirectoronUserRequestBuffer() {
    onUserRequestBuffer();
  }

  public delegate void SwigDelegateICaptureEventHandler_0();
  public delegate void SwigDelegateICaptureEventHandler_1();
  public delegate void SwigDelegateICaptureEventHandler_2();
  public delegate void SwigDelegateICaptureEventHandler_3();
  public delegate void SwigDelegateICaptureEventHandler_4();
  public delegate void SwigDelegateICaptureEventHandler_5();

  private SwigDelegateICaptureEventHandler_0 swigDelegate0;
  private SwigDelegateICaptureEventHandler_1 swigDelegate1;
  private SwigDelegateICaptureEventHandler_2 swigDelegate2;
  private SwigDelegateICaptureEventHandler_3 swigDelegate3;
  private SwigDelegateICaptureEventHandler_4 swigDelegate4;
  private SwigDelegateICaptureEventHandler_5 swigDelegate5;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] {  };
  private static Type[] swigMethodTypes5 = new Type[] {  };
}

}
