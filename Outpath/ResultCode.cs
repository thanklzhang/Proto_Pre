// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ResultCode.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ResultCode.proto</summary>
public static partial class ResultCodeReflection {

  #region Descriptor
  /// <summary>File descriptor for ResultCode.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ResultCodeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBSZXN1bHRDb2RlLnByb3RvKj0KClJlc3VsdENvZGUSCwoHU3VjY2VzcxAA",
          "EhEKDUVSUl9TeXN0ZW1FcnIQARIPCgtFUlJfVW5rbm93bhACYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ResultCode), }, null));
  }
  #endregion

}
#region Enums
public enum ResultCode {
  /// <summary>
  /// None
  /// </summary>
  [pbr::OriginalName("Success")] Success = 0,
  /// <summary>
  /// 系统错误
  /// </summary>
  [pbr::OriginalName("ERR_SystemErr")] ErrSystemErr = 1,
  /// <summary>
  /// 未知错误
  /// </summary>
  [pbr::OriginalName("ERR_Unknown")] ErrUnknown = 2,
}

#endregion


#endregion Designer generated code
