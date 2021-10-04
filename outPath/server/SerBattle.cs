// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: serBattle.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NetProto {

  /// <summary>Holder for reflection information generated from serBattle.proto</summary>
  public static partial class SerBattleReflection {

    #region Descriptor
    /// <summary>File descriptor for serBattle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SerBattleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9zZXJCYXR0bGUucHJvdG8SCE5ldFByb3RvGg9zZXJDb21tb24ucHJvdG8a",
            "DEJhdHRsZS5wcm90byJRChBQbGF5ZXJCYXR0bGVBdHRyEhIKCmFkZGVkTWF4",
            "SHAYBCABKAUSEwoLYWRkZWRBdHRhY2sYBSABKAUSFAoMYWRkZWREZWZlbmNl",
            "GAYgASgFIjAKDVNraWxsSW5pdEluZm8SEAoIY29uZmlnSWQYASABKAUSDQoF",
            "bGV2ZWwYAiABKAUinAEKDkVudGl0eUluaXRJbmZvEhAKCGNvbmZpZ0lkGAEg",
            "ASgFEigKBGF0dHIYAiABKAsyGi5OZXRQcm90by5QbGF5ZXJCYXR0bGVBdHRy",
            "Eg0KBWxldmVsGAMgASgFEhMKC3BsYXllckluZGV4GAQgASgFEioKCXNraWxs",
            "TGlzdBgFIAMoCzIXLk5ldFByb3RvLlNraWxsSW5pdEluZm8igQEKDlBsYXll",
            "ckluaXRJbmZvEgsKA3VpZBgBIAEoBRITCgtwbGF5ZXJJbmRleBgCIAEoBRIM",
            "CgR0ZWFtGAMgASgFEjAKDmVudGl0eUluaXRJbmZvGAQgASgLMhguTmV0UHJv",
            "dG8uRW50aXR5SW5pdEluZm8SDQoFbGV2ZWwYBSABKAUiggEKFWNzQXBwbHlD",
            "cmVhdGVCYXR0bGUyUxIUCgxiYXR0bGVSb29tSWQYASABKAUSEgoKYmF0dGxl",
            "VHlwZRgCIAEoBRIwCg5wbGF5ZXJJbmZvTGlzdBgDIAMoCzIYLk5ldFByb3Rv",
            "LlBsYXllckluaXRJbmZvEg0KBW1hcElkGAQgASgFIlQKFXNjQXBwbHlDcmVh",
            "dGVCYXR0bGUyUxILCgNlcnIYASABKAUSLgoNYmF0dGxlSW5pdEFyZxgCIAEo",
            "CzIXLk5ldFByb3RvLkJhdHRsZUluaXRBcmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NetProto.SerCommonReflection.Descriptor, global::NetProto.BattleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.PlayerBattleAttr), global::NetProto.PlayerBattleAttr.Parser, new[]{ "AddedMaxHp", "AddedAttack", "AddedDefence" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.SkillInitInfo), global::NetProto.SkillInitInfo.Parser, new[]{ "ConfigId", "Level" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.EntityInitInfo), global::NetProto.EntityInitInfo.Parser, new[]{ "ConfigId", "Attr", "Level", "PlayerIndex", "SkillList" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.PlayerInitInfo), global::NetProto.PlayerInitInfo.Parser, new[]{ "Uid", "PlayerIndex", "Team", "EntityInitInfo", "Level" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.csApplyCreateBattle2S), global::NetProto.csApplyCreateBattle2S.Parser, new[]{ "BattleRoomId", "BattleType", "PlayerInfoList", "MapId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.scApplyCreateBattle2S), global::NetProto.scApplyCreateBattle2S.Parser, new[]{ "Err", "BattleInitArg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerBattleAttr : pb::IMessage<PlayerBattleAttr> {
    private static readonly pb::MessageParser<PlayerBattleAttr> _parser = new pb::MessageParser<PlayerBattleAttr>(() => new PlayerBattleAttr());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerBattleAttr> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.SerBattleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerBattleAttr() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerBattleAttr(PlayerBattleAttr other) : this() {
      addedMaxHp_ = other.addedMaxHp_;
      addedAttack_ = other.addedAttack_;
      addedDefence_ = other.addedDefence_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerBattleAttr Clone() {
      return new PlayerBattleAttr(this);
    }

    /// <summary>Field number for the "addedMaxHp" field.</summary>
    public const int AddedMaxHpFieldNumber = 4;
    private int addedMaxHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AddedMaxHp {
      get { return addedMaxHp_; }
      set {
        addedMaxHp_ = value;
      }
    }

    /// <summary>Field number for the "addedAttack" field.</summary>
    public const int AddedAttackFieldNumber = 5;
    private int addedAttack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AddedAttack {
      get { return addedAttack_; }
      set {
        addedAttack_ = value;
      }
    }

    /// <summary>Field number for the "addedDefence" field.</summary>
    public const int AddedDefenceFieldNumber = 6;
    private int addedDefence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AddedDefence {
      get { return addedDefence_; }
      set {
        addedDefence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerBattleAttr);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerBattleAttr other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AddedMaxHp != other.AddedMaxHp) return false;
      if (AddedAttack != other.AddedAttack) return false;
      if (AddedDefence != other.AddedDefence) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AddedMaxHp != 0) hash ^= AddedMaxHp.GetHashCode();
      if (AddedAttack != 0) hash ^= AddedAttack.GetHashCode();
      if (AddedDefence != 0) hash ^= AddedDefence.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AddedMaxHp != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(AddedMaxHp);
      }
      if (AddedAttack != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(AddedAttack);
      }
      if (AddedDefence != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(AddedDefence);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AddedMaxHp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AddedMaxHp);
      }
      if (AddedAttack != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AddedAttack);
      }
      if (AddedDefence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AddedDefence);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerBattleAttr other) {
      if (other == null) {
        return;
      }
      if (other.AddedMaxHp != 0) {
        AddedMaxHp = other.AddedMaxHp;
      }
      if (other.AddedAttack != 0) {
        AddedAttack = other.AddedAttack;
      }
      if (other.AddedDefence != 0) {
        AddedDefence = other.AddedDefence;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 32: {
            AddedMaxHp = input.ReadInt32();
            break;
          }
          case 40: {
            AddedAttack = input.ReadInt32();
            break;
          }
          case 48: {
            AddedDefence = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SkillInitInfo : pb::IMessage<SkillInitInfo> {
    private static readonly pb::MessageParser<SkillInitInfo> _parser = new pb::MessageParser<SkillInitInfo>(() => new SkillInitInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SkillInitInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.SerBattleReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SkillInitInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SkillInitInfo(SkillInitInfo other) : this() {
      configId_ = other.configId_;
      level_ = other.level_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SkillInitInfo Clone() {
      return new SkillInitInfo(this);
    }

    /// <summary>Field number for the "configId" field.</summary>
    public const int ConfigIdFieldNumber = 1;
    private int configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SkillInitInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SkillInitInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      if (Level != other.Level) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ConfigId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ConfigId);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Level);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ConfigId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SkillInitInfo other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ConfigId = input.ReadInt32();
            break;
          }
          case 16: {
            Level = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EntityInitInfo : pb::IMessage<EntityInitInfo> {
    private static readonly pb::MessageParser<EntityInitInfo> _parser = new pb::MessageParser<EntityInitInfo>(() => new EntityInitInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EntityInitInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.SerBattleReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntityInitInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntityInitInfo(EntityInitInfo other) : this() {
      configId_ = other.configId_;
      Attr = other.attr_ != null ? other.Attr.Clone() : null;
      level_ = other.level_;
      playerIndex_ = other.playerIndex_;
      skillList_ = other.skillList_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntityInitInfo Clone() {
      return new EntityInitInfo(this);
    }

    /// <summary>Field number for the "configId" field.</summary>
    public const int ConfigIdFieldNumber = 1;
    private int configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "attr" field.</summary>
    public const int AttrFieldNumber = 2;
    private global::NetProto.PlayerBattleAttr attr_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::NetProto.PlayerBattleAttr Attr {
      get { return attr_; }
      set {
        attr_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 3;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "playerIndex" field.</summary>
    public const int PlayerIndexFieldNumber = 4;
    private int playerIndex_;
    /// <summary>
    /// 玩家索引 0 开始
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerIndex {
      get { return playerIndex_; }
      set {
        playerIndex_ = value;
      }
    }

    /// <summary>Field number for the "skillList" field.</summary>
    public const int SkillListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::NetProto.SkillInitInfo> _repeated_skillList_codec
        = pb::FieldCodec.ForMessage(42, global::NetProto.SkillInitInfo.Parser);
    private readonly pbc::RepeatedField<global::NetProto.SkillInitInfo> skillList_ = new pbc::RepeatedField<global::NetProto.SkillInitInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::NetProto.SkillInitInfo> SkillList {
      get { return skillList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EntityInitInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EntityInitInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      if (!object.Equals(Attr, other.Attr)) return false;
      if (Level != other.Level) return false;
      if (PlayerIndex != other.PlayerIndex) return false;
      if(!skillList_.Equals(other.skillList_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (attr_ != null) hash ^= Attr.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (PlayerIndex != 0) hash ^= PlayerIndex.GetHashCode();
      hash ^= skillList_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ConfigId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ConfigId);
      }
      if (attr_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Attr);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Level);
      }
      if (PlayerIndex != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PlayerIndex);
      }
      skillList_.WriteTo(output, _repeated_skillList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ConfigId);
      }
      if (attr_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Attr);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (PlayerIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerIndex);
      }
      size += skillList_.CalculateSize(_repeated_skillList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EntityInitInfo other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.attr_ != null) {
        if (attr_ == null) {
          attr_ = new global::NetProto.PlayerBattleAttr();
        }
        Attr.MergeFrom(other.Attr);
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.PlayerIndex != 0) {
        PlayerIndex = other.PlayerIndex;
      }
      skillList_.Add(other.skillList_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ConfigId = input.ReadInt32();
            break;
          }
          case 18: {
            if (attr_ == null) {
              attr_ = new global::NetProto.PlayerBattleAttr();
            }
            input.ReadMessage(attr_);
            break;
          }
          case 24: {
            Level = input.ReadInt32();
            break;
          }
          case 32: {
            PlayerIndex = input.ReadInt32();
            break;
          }
          case 42: {
            skillList_.AddEntriesFrom(input, _repeated_skillList_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PlayerInitInfo : pb::IMessage<PlayerInitInfo> {
    private static readonly pb::MessageParser<PlayerInitInfo> _parser = new pb::MessageParser<PlayerInitInfo>(() => new PlayerInitInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerInitInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.SerBattleReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerInitInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerInitInfo(PlayerInitInfo other) : this() {
      uid_ = other.uid_;
      playerIndex_ = other.playerIndex_;
      team_ = other.team_;
      EntityInitInfo = other.entityInitInfo_ != null ? other.EntityInitInfo.Clone() : null;
      level_ = other.level_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerInitInfo Clone() {
      return new PlayerInitInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private int uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "playerIndex" field.</summary>
    public const int PlayerIndexFieldNumber = 2;
    private int playerIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerIndex {
      get { return playerIndex_; }
      set {
        playerIndex_ = value;
      }
    }

    /// <summary>Field number for the "team" field.</summary>
    public const int TeamFieldNumber = 3;
    private int team_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Team {
      get { return team_; }
      set {
        team_ = value;
      }
    }

    /// <summary>Field number for the "entityInitInfo" field.</summary>
    public const int EntityInitInfoFieldNumber = 4;
    private global::NetProto.EntityInitInfo entityInitInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::NetProto.EntityInitInfo EntityInitInfo {
      get { return entityInitInfo_; }
      set {
        entityInitInfo_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 5;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerInitInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerInitInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (PlayerIndex != other.PlayerIndex) return false;
      if (Team != other.Team) return false;
      if (!object.Equals(EntityInitInfo, other.EntityInitInfo)) return false;
      if (Level != other.Level) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (PlayerIndex != 0) hash ^= PlayerIndex.GetHashCode();
      if (Team != 0) hash ^= Team.GetHashCode();
      if (entityInitInfo_ != null) hash ^= EntityInitInfo.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Uid);
      }
      if (PlayerIndex != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PlayerIndex);
      }
      if (Team != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Team);
      }
      if (entityInitInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EntityInitInfo);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Level);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Uid);
      }
      if (PlayerIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerIndex);
      }
      if (Team != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Team);
      }
      if (entityInitInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityInitInfo);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerInitInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.PlayerIndex != 0) {
        PlayerIndex = other.PlayerIndex;
      }
      if (other.Team != 0) {
        Team = other.Team;
      }
      if (other.entityInitInfo_ != null) {
        if (entityInitInfo_ == null) {
          entityInitInfo_ = new global::NetProto.EntityInitInfo();
        }
        EntityInitInfo.MergeFrom(other.EntityInitInfo);
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Uid = input.ReadInt32();
            break;
          }
          case 16: {
            PlayerIndex = input.ReadInt32();
            break;
          }
          case 24: {
            Team = input.ReadInt32();
            break;
          }
          case 34: {
            if (entityInitInfo_ == null) {
              entityInitInfo_ = new global::NetProto.EntityInitInfo();
            }
            input.ReadMessage(entityInitInfo_);
            break;
          }
          case 40: {
            Level = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 申请从战斗服务器创建一场战斗
  /// </summary>
  public sealed partial class csApplyCreateBattle2S : pb::IMessage<csApplyCreateBattle2S> {
    private static readonly pb::MessageParser<csApplyCreateBattle2S> _parser = new pb::MessageParser<csApplyCreateBattle2S>(() => new csApplyCreateBattle2S());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<csApplyCreateBattle2S> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.SerBattleReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csApplyCreateBattle2S() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csApplyCreateBattle2S(csApplyCreateBattle2S other) : this() {
      battleRoomId_ = other.battleRoomId_;
      battleType_ = other.battleType_;
      playerInfoList_ = other.playerInfoList_.Clone();
      mapId_ = other.mapId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csApplyCreateBattle2S Clone() {
      return new csApplyCreateBattle2S(this);
    }

    /// <summary>Field number for the "battleRoomId" field.</summary>
    public const int BattleRoomIdFieldNumber = 1;
    private int battleRoomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleRoomId {
      get { return battleRoomId_; }
      set {
        battleRoomId_ = value;
      }
    }

    /// <summary>Field number for the "battleType" field.</summary>
    public const int BattleTypeFieldNumber = 2;
    private int battleType_;
    /// <summary>
    /// 1 英雄试炼 (这里可能会走 activityId 和 活动 挂钩)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleType {
      get { return battleType_; }
      set {
        battleType_ = value;
      }
    }

    /// <summary>Field number for the "playerInfoList" field.</summary>
    public const int PlayerInfoListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::NetProto.PlayerInitInfo> _repeated_playerInfoList_codec
        = pb::FieldCodec.ForMessage(26, global::NetProto.PlayerInitInfo.Parser);
    private readonly pbc::RepeatedField<global::NetProto.PlayerInitInfo> playerInfoList_ = new pbc::RepeatedField<global::NetProto.PlayerInitInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::NetProto.PlayerInitInfo> PlayerInfoList {
      get { return playerInfoList_; }
    }

    /// <summary>Field number for the "mapId" field.</summary>
    public const int MapIdFieldNumber = 4;
    private int mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as csApplyCreateBattle2S);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(csApplyCreateBattle2S other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BattleRoomId != other.BattleRoomId) return false;
      if (BattleType != other.BattleType) return false;
      if(!playerInfoList_.Equals(other.playerInfoList_)) return false;
      if (MapId != other.MapId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BattleRoomId != 0) hash ^= BattleRoomId.GetHashCode();
      if (BattleType != 0) hash ^= BattleType.GetHashCode();
      hash ^= playerInfoList_.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BattleRoomId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BattleRoomId);
      }
      if (BattleType != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BattleType);
      }
      playerInfoList_.WriteTo(output, _repeated_playerInfoList_codec);
      if (MapId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MapId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BattleRoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleRoomId);
      }
      if (BattleType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleType);
      }
      size += playerInfoList_.CalculateSize(_repeated_playerInfoList_codec);
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MapId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(csApplyCreateBattle2S other) {
      if (other == null) {
        return;
      }
      if (other.BattleRoomId != 0) {
        BattleRoomId = other.BattleRoomId;
      }
      if (other.BattleType != 0) {
        BattleType = other.BattleType;
      }
      playerInfoList_.Add(other.playerInfoList_);
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            BattleRoomId = input.ReadInt32();
            break;
          }
          case 16: {
            BattleType = input.ReadInt32();
            break;
          }
          case 26: {
            playerInfoList_.AddEntriesFrom(input, _repeated_playerInfoList_codec);
            break;
          }
          case 32: {
            MapId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class scApplyCreateBattle2S : pb::IMessage<scApplyCreateBattle2S> {
    private static readonly pb::MessageParser<scApplyCreateBattle2S> _parser = new pb::MessageParser<scApplyCreateBattle2S>(() => new scApplyCreateBattle2S());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<scApplyCreateBattle2S> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.SerBattleReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scApplyCreateBattle2S() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scApplyCreateBattle2S(scApplyCreateBattle2S other) : this() {
      err_ = other.err_;
      BattleInitArg = other.battleInitArg_ != null ? other.BattleInitArg.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scApplyCreateBattle2S Clone() {
      return new scApplyCreateBattle2S(this);
    }

    /// <summary>Field number for the "err" field.</summary>
    public const int ErrFieldNumber = 1;
    private int err_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Err {
      get { return err_; }
      set {
        err_ = value;
      }
    }

    /// <summary>Field number for the "battleInitArg" field.</summary>
    public const int BattleInitArgFieldNumber = 2;
    private global::NetProto.BattleInitArg battleInitArg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::NetProto.BattleInitArg BattleInitArg {
      get { return battleInitArg_; }
      set {
        battleInitArg_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as scApplyCreateBattle2S);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(scApplyCreateBattle2S other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Err != other.Err) return false;
      if (!object.Equals(BattleInitArg, other.BattleInitArg)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Err != 0) hash ^= Err.GetHashCode();
      if (battleInitArg_ != null) hash ^= BattleInitArg.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Err != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Err);
      }
      if (battleInitArg_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BattleInitArg);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Err != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Err);
      }
      if (battleInitArg_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInitArg);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(scApplyCreateBattle2S other) {
      if (other == null) {
        return;
      }
      if (other.Err != 0) {
        Err = other.Err;
      }
      if (other.battleInitArg_ != null) {
        if (battleInitArg_ == null) {
          battleInitArg_ = new global::NetProto.BattleInitArg();
        }
        BattleInitArg.MergeFrom(other.BattleInitArg);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Err = input.ReadInt32();
            break;
          }
          case 18: {
            if (battleInitArg_ == null) {
              battleInitArg_ = new global::NetProto.BattleInitArg();
            }
            input.ReadMessage(battleInitArg_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code