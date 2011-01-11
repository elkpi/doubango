/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class RegistrationEvent : SipEvent {
  private HandleRef swigCPtr;

  internal RegistrationEvent(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.RegistrationEventUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RegistrationEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RegistrationEvent() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_RegistrationEvent(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public tsip_register_event_type_t getType() {
    tsip_register_event_type_t ret = (tsip_register_event_type_t)tinyWRAPPINVOKE.RegistrationEvent_getType(swigCPtr);
    return ret;
  }

  public RegistrationSession getSession() {
    IntPtr cPtr = tinyWRAPPINVOKE.RegistrationEvent_getSession(swigCPtr);
    RegistrationSession ret = (cPtr == IntPtr.Zero) ? null : new RegistrationSession(cPtr, false);
    return ret;
  }

  public RegistrationSession takeSessionOwnership() {
    IntPtr cPtr = tinyWRAPPINVOKE.RegistrationEvent_takeSessionOwnership(swigCPtr);
    RegistrationSession ret = (cPtr == IntPtr.Zero) ? null : new RegistrationSession(cPtr, true);
    return ret;
  }

}

}
