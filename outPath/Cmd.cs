// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cmd.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NetProto {

  /// <summary>Holder for reflection information generated from Cmd.proto</summary>
  public static partial class CmdReflection {

    #region Descriptor
    /// <summary>File descriptor for Cmd.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CmdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglDbWQucHJvdG8SCE5ldFByb3RvKlkKCFByb3RvSURzEgkKBUZpcnN0EAAS",
            "EAoMQ2hlY2tMb2dpbjJTEGUSDwoLRW50ZXJHYW1lMlMQZhIPCgpDaGVja0xv",
            "Z2luELkXEg4KCUVudGVyR2FtZRC6F2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NetProto.ProtoIDs), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ProtoIDs {
    [pbr::OriginalName("First")] First = 0,
    /// <summary>
    /// 1 -- 3000 服务端
    /// </summary>
    [pbr::OriginalName("CheckLogin2S")] CheckLogin2S = 101,
    [pbr::OriginalName("EnterGame2S")] EnterGame2S = 102,
    /// <summary>
    /// 3000+ 客户端
    /// </summary>
    [pbr::OriginalName("CheckLogin")] CheckLogin = 3001,
    [pbr::OriginalName("EnterGame")] EnterGame = 3002,
  }

  #endregion

}

#endregion Designer generated code
