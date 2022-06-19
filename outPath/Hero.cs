// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Hero.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NetProto {

  /// <summary>Holder for reflection information generated from Hero.proto</summary>
  public static partial class HeroReflection {

    #region Descriptor
    /// <summary>File descriptor for Hero.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeroReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpIZXJvLnByb3RvEghOZXRQcm90bxoMQ29tbW9uLnByb3RvIhAKDmNzU3lu",
            "Y0hlcm9MaXN0IkQKDnNjU3luY0hlcm9MaXN0EgsKA2VychgBIAEoBRIlCgho",
            "ZXJvTGlzdBgCIAMoCzITLk5ldFByb3RvLkhlcm9Qcm90byIxChJjc1VwZ3Jh",
            "ZGVIZXJvTGV2ZWwSDAoEZ3VpZBgBIAEoBRINCgVsZXZlbBgCIAEoBSIhChJz",
            "Y1VwZ3JhZGVIZXJvTGV2ZWwSCwoDZXJyGAEgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NetProto.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.csSyncHeroList), global::NetProto.csSyncHeroList.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.scSyncHeroList), global::NetProto.scSyncHeroList.Parser, new[]{ "Err", "HeroList" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.csUpgradeHeroLevel), global::NetProto.csUpgradeHeroLevel.Parser, new[]{ "Guid", "Level" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.scUpgradeHeroLevel), global::NetProto.scUpgradeHeroLevel.Parser, new[]{ "Err" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class csSyncHeroList : pb::IMessage<csSyncHeroList> {
    private static readonly pb::MessageParser<csSyncHeroList> _parser = new pb::MessageParser<csSyncHeroList>(() => new csSyncHeroList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<csSyncHeroList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.HeroReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csSyncHeroList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csSyncHeroList(csSyncHeroList other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csSyncHeroList Clone() {
      return new csSyncHeroList(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as csSyncHeroList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(csSyncHeroList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(csSyncHeroList other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class scSyncHeroList : pb::IMessage<scSyncHeroList> {
    private static readonly pb::MessageParser<scSyncHeroList> _parser = new pb::MessageParser<scSyncHeroList>(() => new scSyncHeroList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<scSyncHeroList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.HeroReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scSyncHeroList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scSyncHeroList(scSyncHeroList other) : this() {
      err_ = other.err_;
      heroList_ = other.heroList_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scSyncHeroList Clone() {
      return new scSyncHeroList(this);
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

    /// <summary>Field number for the "heroList" field.</summary>
    public const int HeroListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::NetProto.HeroProto> _repeated_heroList_codec
        = pb::FieldCodec.ForMessage(18, global::NetProto.HeroProto.Parser);
    private readonly pbc::RepeatedField<global::NetProto.HeroProto> heroList_ = new pbc::RepeatedField<global::NetProto.HeroProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::NetProto.HeroProto> HeroList {
      get { return heroList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as scSyncHeroList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(scSyncHeroList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Err != other.Err) return false;
      if(!heroList_.Equals(other.heroList_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Err != 0) hash ^= Err.GetHashCode();
      hash ^= heroList_.GetHashCode();
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
      heroList_.WriteTo(output, _repeated_heroList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Err != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Err);
      }
      size += heroList_.CalculateSize(_repeated_heroList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(scSyncHeroList other) {
      if (other == null) {
        return;
      }
      if (other.Err != 0) {
        Err = other.Err;
      }
      heroList_.Add(other.heroList_);
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
            heroList_.AddEntriesFrom(input, _repeated_heroList_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class csUpgradeHeroLevel : pb::IMessage<csUpgradeHeroLevel> {
    private static readonly pb::MessageParser<csUpgradeHeroLevel> _parser = new pb::MessageParser<csUpgradeHeroLevel>(() => new csUpgradeHeroLevel());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<csUpgradeHeroLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.HeroReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csUpgradeHeroLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csUpgradeHeroLevel(csUpgradeHeroLevel other) : this() {
      guid_ = other.guid_;
      level_ = other.level_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public csUpgradeHeroLevel Clone() {
      return new csUpgradeHeroLevel(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 1;
    private int guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Guid {
      get { return guid_; }
      set {
        guid_ = value;
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
      return Equals(other as csUpgradeHeroLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(csUpgradeHeroLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (Level != other.Level) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Guid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Guid);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Level);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Guid);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(csUpgradeHeroLevel other) {
      if (other == null) {
        return;
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
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
            Guid = input.ReadInt32();
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

  public sealed partial class scUpgradeHeroLevel : pb::IMessage<scUpgradeHeroLevel> {
    private static readonly pb::MessageParser<scUpgradeHeroLevel> _parser = new pb::MessageParser<scUpgradeHeroLevel>(() => new scUpgradeHeroLevel());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<scUpgradeHeroLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.HeroReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scUpgradeHeroLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scUpgradeHeroLevel(scUpgradeHeroLevel other) : this() {
      err_ = other.err_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public scUpgradeHeroLevel Clone() {
      return new scUpgradeHeroLevel(this);
    }

    /// <summary>Field number for the "err" field.</summary>
    public const int ErrFieldNumber = 1;
    private int err_;
    /// <summary>
    /// HeroProto hero = 2;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Err {
      get { return err_; }
      set {
        err_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as scUpgradeHeroLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(scUpgradeHeroLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Err != other.Err) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Err != 0) hash ^= Err.GetHashCode();
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
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Err != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Err);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(scUpgradeHeroLevel other) {
      if (other == null) {
        return;
      }
      if (other.Err != 0) {
        Err = other.Err;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
