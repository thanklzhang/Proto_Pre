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
            "CglDbWQucHJvdG8SCE5ldFByb3RvKqgICghQcm90b0lEcxIJCgVGaXJzdBAA",
            "EhAKDENoZWNrTG9naW4yUxBlEg8KC0VudGVyR2FtZTJTEGYSEwoPUmVnaXN0",
            "QWNjb3VudDJTEGcSGAoTQXBwbHlDcmVhdGVCYXR0bGUyUxDJARIXChJUcmFu",
            "c2l0aW9uQmF0dGxlMlMQrQISHgoZVHJhbnNpdGlvbkJhdHRsZTJQbGF5ZXIy",
            "UxCuAhIWChFOb3RpZnlCYXR0bGVFbmQyUxCvAhIPCgpDaGVja0xvZ2luENEP",
            "Eg4KCUVudGVyR2FtZRDSDxISCg1SZWdpc3RBY2NvdW50ENMPEhEKDFN5bmNN",
            "YWluVGFzaxDaDxIYChNGaW5pc2hNYWluVGFza1N0YWdlENsPEhkKFFJlY2Vp",
            "dmVNYWluVGFza1J3YXJkENwPEgwKB1N5bmNCYWcQ5A8SDwoKVXBkYXRlSXRl",
            "bRDlDxIRCgxTeW5jSGVyb0xpc3QQ7g8SEwoOVXBkYXRlSGVyb0xpc3QQ7w8S",
            "FQoQVXBncmFkZUhlcm9MZXZlbBDwDxIYChNBcHBseUhlcm9FeGFtQmF0dGxl",
            "ELQQEhgKE0FwcGx5TWFpblRhc2tCYXR0bGUQtRASFwoSTm90aWZ5Q3JlYXRl",
            "QmF0dGxlELkXEhcKElBsYXllckxvYWRQcm9ncmVzcxC6FxIeChlOb3RpZnlB",
            "bGxQbGF5ZXJMb2FkRmluaXNoELsXEhYKEUJhdHRsZVJlYWR5RmluaXNoELwX",
            "EhYKEU5vdGlmeUJhdHRsZVN0YXJ0EL0XEg8KCk1vdmVFbnRpdHkQnRgSDQoI",
            "VXNlU2tpbGwQnhgSEgoNQ2xpZW50UGxvdEVuZBC6GBIZChROb3RpZnlDcmVh",
            "dGVFbnRpdGllcxCBGRIVChBOb3RpZnlFbnRpdHlNb3ZlEIIZEhkKFE5vdGlm",
            "eUVudGl0eVN0b3BNb3ZlEIMZEh0KGE5vdGlmeUVudGl0eVJlbGVhc2VTa2ls",
            "bBCEGRIcChdOb3RpZnlDcmVhdGVTa2lsbEVmZmVjdBCFGRIfChpOb3RpZnlT",
            "a2lsbEVmZmVjdFN0YXJ0TW92ZRCGGRIdChhOb3RpZnlTa2lsbEVmZmVjdERl",
            "c3Ryb3kQhxkSGQoUTm90aWZ5U3luY0VudGl0eUF0dHIQiBkSGgoVTm90aWZ5",
            "U3luY0VudGl0eVZhbHVlEIkZEhUKEE5vdGlmeUVudGl0eURlYWQQihkSFAoP",
            "Tm90aWZ5QmF0dGxlRW5kEIsZEhMKDk5vdGlmeVBsYXlQbG90EIwZEhIKDU5v",
            "dGlmeVBsb3RFbmQQjRkSHQoYTm90aWZ5U2V0RW50aXR5U2hvd1N0YXRlEI4Z",
            "EhUKEFRyYW5zaXRpb25CYXR0bGUQ5RkSHAoXVHJhbnNpdGlvbkJhdHRsZTJQ",
            "bGF5ZXIQ5hliBnByb3RvMw=="));
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
    /// 1 -- 2000 服务端----------------------------------------------
    /// </summary>
    [pbr::OriginalName("CheckLogin2S")] CheckLogin2S = 101,
    [pbr::OriginalName("EnterGame2S")] EnterGame2S = 102,
    [pbr::OriginalName("RegistAccount2S")] RegistAccount2S = 103,
    [pbr::OriginalName("ApplyCreateBattle2S")] ApplyCreateBattle2S = 201,
    [pbr::OriginalName("TransitionBattle2S")] TransitionBattle2S = 301,
    [pbr::OriginalName("TransitionBattle2Player2S")] TransitionBattle2Player2S = 302,
    [pbr::OriginalName("NotifyBattleEnd2S")] NotifyBattleEnd2S = 303,
    /// <summary>
    /// 2000+ 客户端--------------------------------------------------
    /// </summary>
    [pbr::OriginalName("CheckLogin")] CheckLogin = 2001,
    [pbr::OriginalName("EnterGame")] EnterGame = 2002,
    [pbr::OriginalName("RegistAccount")] RegistAccount = 2003,
    /// <summary>
    /// 主线任务
    /// </summary>
    [pbr::OriginalName("SyncMainTask")] SyncMainTask = 2010,
    [pbr::OriginalName("FinishMainTaskStage")] FinishMainTaskStage = 2011,
    [pbr::OriginalName("ReceiveMainTaskRward")] ReceiveMainTaskRward = 2012,
    /// <summary>
    /// 背包
    /// </summary>
    [pbr::OriginalName("SyncBag")] SyncBag = 2020,
    [pbr::OriginalName("UpdateItem")] UpdateItem = 2021,
    /// <summary>
    /// 英雄
    /// </summary>
    [pbr::OriginalName("SyncHeroList")] SyncHeroList = 2030,
    [pbr::OriginalName("UpdateHeroList")] UpdateHeroList = 2031,
    [pbr::OriginalName("UpgradeHeroLevel")] UpgradeHeroLevel = 2032,
    /// <summary>
    /// 战斗入口
    /// </summary>
    [pbr::OriginalName("ApplyHeroExamBattle")] ApplyHeroExamBattle = 2100,
    /// <summary>
    /// 主线
    /// </summary>
    [pbr::OriginalName("ApplyMainTaskBattle")] ApplyMainTaskBattle = 2101,
    /// <summary>
    /// 战斗开始流程
    /// </summary>
    [pbr::OriginalName("NotifyCreateBattle")] NotifyCreateBattle = 3001,
    [pbr::OriginalName("PlayerLoadProgress")] PlayerLoadProgress = 3002,
    [pbr::OriginalName("NotifyAllPlayerLoadFinish")] NotifyAllPlayerLoadFinish = 3003,
    [pbr::OriginalName("BattleReadyFinish")] BattleReadyFinish = 3004,
    [pbr::OriginalName("NotifyBattleStart")] NotifyBattleStart = 3005,
    /// <summary>
    /// 玩家操作
    /// </summary>
    [pbr::OriginalName("MoveEntity")] MoveEntity = 3101,
    [pbr::OriginalName("UseSkill")] UseSkill = 3102,
    [pbr::OriginalName("ClientPlotEnd")] ClientPlotEnd = 3130,
    /// <summary>
    /// 服务端发来的关键战斗事件
    /// </summary>
    [pbr::OriginalName("NotifyCreateEntities")] NotifyCreateEntities = 3201,
    [pbr::OriginalName("NotifyEntityMove")] NotifyEntityMove = 3202,
    [pbr::OriginalName("NotifyEntityStopMove")] NotifyEntityStopMove = 3203,
    [pbr::OriginalName("NotifyEntityReleaseSkill")] NotifyEntityReleaseSkill = 3204,
    [pbr::OriginalName("NotifyCreateSkillEffect")] NotifyCreateSkillEffect = 3205,
    [pbr::OriginalName("NotifySkillEffectStartMove")] NotifySkillEffectStartMove = 3206,
    [pbr::OriginalName("NotifySkillEffectDestroy")] NotifySkillEffectDestroy = 3207,
    [pbr::OriginalName("NotifySyncEntityAttr")] NotifySyncEntityAttr = 3208,
    [pbr::OriginalName("NotifySyncEntityValue")] NotifySyncEntityValue = 3209,
    [pbr::OriginalName("NotifyEntityDead")] NotifyEntityDead = 3210,
    [pbr::OriginalName("NotifyBattleEnd")] NotifyBattleEnd = 3211,
    [pbr::OriginalName("NotifyPlayPlot")] NotifyPlayPlot = 3212,
    [pbr::OriginalName("NotifyPlotEnd")] NotifyPlotEnd = 3213,
    [pbr::OriginalName("NotifySetEntityShowState")] NotifySetEntityShowState = 3214,
    /// <summary>
    /// 转发战斗
    /// </summary>
    [pbr::OriginalName("TransitionBattle")] TransitionBattle = 3301,
    [pbr::OriginalName("TransitionBattle2Player")] TransitionBattle2Player = 3302,
  }

  #endregion

}

#endregion Designer generated code
