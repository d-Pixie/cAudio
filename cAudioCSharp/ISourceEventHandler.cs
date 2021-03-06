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

public class ISourceEventHandler : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ISourceEventHandler(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ISourceEventHandler obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ISourceEventHandler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cAudioCSharpWrapperPINVOKE.delete_ISourceEventHandler(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void onUpdate() {
    cAudioCSharpWrapperPINVOKE.ISourceEventHandler_onUpdate(swigCPtr);
  }

  public virtual void onRelease() {
    cAudioCSharpWrapperPINVOKE.ISourceEventHandler_onRelease(swigCPtr);
  }

  public virtual void onPlay() {
    cAudioCSharpWrapperPINVOKE.ISourceEventHandler_onPlay(swigCPtr);
  }

  public virtual void onStop() {
    cAudioCSharpWrapperPINVOKE.ISourceEventHandler_onStop(swigCPtr);
  }

  public virtual void onPause() {
    cAudioCSharpWrapperPINVOKE.ISourceEventHandler_onPause(swigCPtr);
  }

  public ISourceEventHandler() : this(cAudioCSharpWrapperPINVOKE.new_ISourceEventHandler(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onUpdate", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateISourceEventHandler_0(SwigDirectoronUpdate);
    if (SwigDerivedClassHasMethod("onRelease", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateISourceEventHandler_1(SwigDirectoronRelease);
    if (SwigDerivedClassHasMethod("onPlay", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateISourceEventHandler_2(SwigDirectoronPlay);
    if (SwigDerivedClassHasMethod("onStop", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateISourceEventHandler_3(SwigDirectoronStop);
    if (SwigDerivedClassHasMethod("onPause", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateISourceEventHandler_4(SwigDirectoronPause);
    cAudioCSharpWrapperPINVOKE.ISourceEventHandler_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ISourceEventHandler));
    return hasDerivedMethod;
  }

  private void SwigDirectoronUpdate() {
    onUpdate();
  }

  private void SwigDirectoronRelease() {
    onRelease();
  }

  private void SwigDirectoronPlay() {
    onPlay();
  }

  private void SwigDirectoronStop() {
    onStop();
  }

  private void SwigDirectoronPause() {
    onPause();
  }

  public delegate void SwigDelegateISourceEventHandler_0();
  public delegate void SwigDelegateISourceEventHandler_1();
  public delegate void SwigDelegateISourceEventHandler_2();
  public delegate void SwigDelegateISourceEventHandler_3();
  public delegate void SwigDelegateISourceEventHandler_4();

  private SwigDelegateISourceEventHandler_0 swigDelegate0;
  private SwigDelegateISourceEventHandler_1 swigDelegate1;
  private SwigDelegateISourceEventHandler_2 swigDelegate2;
  private SwigDelegateISourceEventHandler_3 swigDelegate3;
  private SwigDelegateISourceEventHandler_4 swigDelegate4;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] {  };
}

}
