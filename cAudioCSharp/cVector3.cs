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

public class cVector3 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal cVector3(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(cVector3 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~cVector3() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cAudioCSharpWrapperPINVOKE.delete_cVector3(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


  public static bool operator>(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.GreaterThan(rhs);
  }
  
  public static bool operator>=(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.GreaterThan(rhs) || lhs.EqualEqual(rhs);
  }
  
  public static bool operator<(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.LessThan(rhs);
  }
  
  public static bool operator<=(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.LessThan(rhs) || lhs.EqualEqual(rhs);
  }
  
  public static cVector3 operator+(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.Plus(rhs);
  }

  public static cVector3 operator*(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.Multiply(rhs);
  }
  
  public static cVector3 operator*(cVector3 lhs, float rhs) 
  {
    return lhs.Multiply(rhs);
  }
  
  public static cVector3 operator/(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.Divide(rhs);
  }
  
  public static cVector3 operator/(cVector3 lhs, float rhs) 
  {
    return lhs.Divide(rhs);
  }
     
  public static cVector3 operator-(cVector3 lhs, cVector3 rhs) 
  {
    return lhs.Minus(rhs);
  }

  public float x {
    set {
      cAudioCSharpWrapperPINVOKE.cVector3_x_set(swigCPtr, value);
    } 
    get {
      float ret = cAudioCSharpWrapperPINVOKE.cVector3_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      cAudioCSharpWrapperPINVOKE.cVector3_y_set(swigCPtr, value);
    } 
    get {
      float ret = cAudioCSharpWrapperPINVOKE.cVector3_y_get(swigCPtr);
      return ret;
    } 
  }

  public float z {
    set {
      cAudioCSharpWrapperPINVOKE.cVector3_z_set(swigCPtr, value);
    } 
    get {
      float ret = cAudioCSharpWrapperPINVOKE.cVector3_z_get(swigCPtr);
      return ret;
    } 
  }

  public cVector3() : this(cAudioCSharpWrapperPINVOKE.new_cVector3__SWIG_0(), true) {
  }

  public cVector3(float nx, float ny, float nz) : this(cAudioCSharpWrapperPINVOKE.new_cVector3__SWIG_1(nx, ny, nz), true) {
  }

  public cVector3(float n) : this(cAudioCSharpWrapperPINVOKE.new_cVector3__SWIG_2(n), true) {
  }

  public cVector3(cVector3 other) : this(cAudioCSharpWrapperPINVOKE.new_cVector3__SWIG_3(cVector3.getCPtr(other)), true) {
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public cVector3(SWIGTYPE_p_float vector) : this(cAudioCSharpWrapperPINVOKE.new_cVector3__SWIG_4(SWIGTYPE_p_float.getCPtr(vector)), true) {
  }

  public cVector3 Minus() {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Minus__SWIG_0(swigCPtr), true);
    return ret;
  }

  public cVector3 Equal(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Equal(swigCPtr, cVector3.getCPtr(other)), false);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 Plus(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Plus__SWIG_0(swigCPtr, cVector3.getCPtr(other)), true);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 PlusEqual(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_PlusEqual__SWIG_0(swigCPtr, cVector3.getCPtr(other)), false);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 Plus(float val) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Plus__SWIG_1(swigCPtr, val), true);
    return ret;
  }

  public cVector3 PlusEqual(float val) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_PlusEqual__SWIG_1(swigCPtr, val), false);
    return ret;
  }

  public cVector3 Minus(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Minus__SWIG_1(swigCPtr, cVector3.getCPtr(other)), true);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 MinusEqual(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_MinusEqual__SWIG_0(swigCPtr, cVector3.getCPtr(other)), false);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 Minus(float val) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Minus__SWIG_2(swigCPtr, val), true);
    return ret;
  }

  public cVector3 MinusEqual(float val) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_MinusEqual__SWIG_1(swigCPtr, val), false);
    return ret;
  }

  public cVector3 Multiply(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Multiply__SWIG_0(swigCPtr, cVector3.getCPtr(other)), true);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 MultiplyEqual(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_MultiplyEqual__SWIG_0(swigCPtr, cVector3.getCPtr(other)), false);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 Multiply(float v) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Multiply__SWIG_1(swigCPtr, v), true);
    return ret;
  }

  public cVector3 MultiplyEqual(float v) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_MultiplyEqual__SWIG_1(swigCPtr, v), false);
    return ret;
  }

  public cVector3 Divide(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Divide__SWIG_0(swigCPtr, cVector3.getCPtr(other)), true);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 DivideEqual(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_DivideEqual__SWIG_0(swigCPtr, cVector3.getCPtr(other)), false);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 Divide(float v) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_Divide__SWIG_1(swigCPtr, v), true);
    return ret;
  }

  public cVector3 DivideEqual(float v) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_DivideEqual__SWIG_1(swigCPtr, v), false);
    return ret;
  }

  public bool LessThanEqual(cVector3 other) {
    bool ret = cAudioCSharpWrapperPINVOKE.cVector3_LessThanEqual(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GreaterThanEqual(cVector3 other) {
    bool ret = cAudioCSharpWrapperPINVOKE.cVector3_GreaterThanEqual(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool LessThan(cVector3 other) {
    bool ret = cAudioCSharpWrapperPINVOKE.cVector3_LessThan(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GreaterThan(cVector3 other) {
    bool ret = cAudioCSharpWrapperPINVOKE.cVector3_GreaterThan(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EqualEqual(cVector3 other) {
    bool ret = cAudioCSharpWrapperPINVOKE.cVector3_EqualEqual(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool NotEqual(cVector3 other) {
    bool ret = cAudioCSharpWrapperPINVOKE.cVector3_NotEqual(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float length() {
    float ret = cAudioCSharpWrapperPINVOKE.cVector3_length(swigCPtr);
    return ret;
  }

  public void normalize() {
    cAudioCSharpWrapperPINVOKE.cVector3_normalize(swigCPtr);
  }

  public float dot(cVector3 other) {
    float ret = cAudioCSharpWrapperPINVOKE.cVector3_dot(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public cVector3 cross(cVector3 other) {
    cVector3 ret = new cVector3(cAudioCSharpWrapperPINVOKE.cVector3_cross(swigCPtr, cVector3.getCPtr(other)), true);
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set(float nx, float ny, float nz) {
    cAudioCSharpWrapperPINVOKE.cVector3_set__SWIG_0(swigCPtr, nx, ny, nz);
  }

  public void set(float n) {
    cAudioCSharpWrapperPINVOKE.cVector3_set__SWIG_1(swigCPtr, n);
  }

  public void set(cVector3 other) {
    cAudioCSharpWrapperPINVOKE.cVector3_set__SWIG_2(swigCPtr, cVector3.getCPtr(other));
    if (cAudioCSharpWrapperPINVOKE.SWIGPendingException.Pending) throw cAudioCSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getAsArray(SWIGTYPE_p_float output) {
    cAudioCSharpWrapperPINVOKE.cVector3_getAsArray(swigCPtr, SWIGTYPE_p_float.getCPtr(output));
  }

}

}
