// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/PlayerLevelUpResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/PlayerLevelUpResponse.proto</summary>
  public static partial class PlayerLevelUpResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/PlayerLevelUpResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerLevelUpResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9QbGF5ZXJMZXZlbFVw",
            "UmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "GiNXVVByb3Rvcy9EYXRhL0xvb3QvTG9vdFJld2FyZC5wcm90byKIAQoVUGxh",
            "eWVyTGV2ZWxVcFJlc3BvbnNlEhQKDGRpZF9sZXZlbF91cBgBIAEoCBIRCglu",
            "ZXdfbGV2ZWwYAiABKAUSRgoPZ3JhbnRlZF9yZXdhcmRzGAMgASgLMi0uV1VQ",
            "cm90b3MuRGF0YS5Mb290Lkxvb3RSZXdhcmQuTG9vdENvbGxlY3Rpb25iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.PlayerLevelUpResponse), global::WUProtos.Networking.Responses.PlayerLevelUpResponse.Parser, new[]{ "DidLevelUp", "NewLevel", "GrantedRewards" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerLevelUpResponse : pb::IMessage<PlayerLevelUpResponse> {
    private static readonly pb::MessageParser<PlayerLevelUpResponse> _parser = new pb::MessageParser<PlayerLevelUpResponse>(() => new PlayerLevelUpResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerLevelUpResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.PlayerLevelUpResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerLevelUpResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerLevelUpResponse(PlayerLevelUpResponse other) : this() {
      didLevelUp_ = other.didLevelUp_;
      newLevel_ = other.newLevel_;
      grantedRewards_ = other.grantedRewards_ != null ? other.grantedRewards_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerLevelUpResponse Clone() {
      return new PlayerLevelUpResponse(this);
    }

    /// <summary>Field number for the "did_level_up" field.</summary>
    public const int DidLevelUpFieldNumber = 1;
    private bool didLevelUp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DidLevelUp {
      get { return didLevelUp_; }
      set {
        didLevelUp_ = value;
      }
    }

    /// <summary>Field number for the "new_level" field.</summary>
    public const int NewLevelFieldNumber = 2;
    private int newLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NewLevel {
      get { return newLevel_; }
      set {
        newLevel_ = value;
      }
    }

    /// <summary>Field number for the "granted_rewards" field.</summary>
    public const int GrantedRewardsFieldNumber = 3;
    private global::WUProtos.Data.Loot.LootReward.Types.LootCollection grantedRewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootReward.Types.LootCollection GrantedRewards {
      get { return grantedRewards_; }
      set {
        grantedRewards_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerLevelUpResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerLevelUpResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DidLevelUp != other.DidLevelUp) return false;
      if (NewLevel != other.NewLevel) return false;
      if (!object.Equals(GrantedRewards, other.GrantedRewards)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DidLevelUp != false) hash ^= DidLevelUp.GetHashCode();
      if (NewLevel != 0) hash ^= NewLevel.GetHashCode();
      if (grantedRewards_ != null) hash ^= GrantedRewards.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DidLevelUp != false) {
        output.WriteRawTag(8);
        output.WriteBool(DidLevelUp);
      }
      if (NewLevel != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(NewLevel);
      }
      if (grantedRewards_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GrantedRewards);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DidLevelUp != false) {
        size += 1 + 1;
      }
      if (NewLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NewLevel);
      }
      if (grantedRewards_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrantedRewards);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerLevelUpResponse other) {
      if (other == null) {
        return;
      }
      if (other.DidLevelUp != false) {
        DidLevelUp = other.DidLevelUp;
      }
      if (other.NewLevel != 0) {
        NewLevel = other.NewLevel;
      }
      if (other.grantedRewards_ != null) {
        if (grantedRewards_ == null) {
          GrantedRewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
        }
        GrantedRewards.MergeFrom(other.GrantedRewards);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            DidLevelUp = input.ReadBool();
            break;
          }
          case 16: {
            NewLevel = input.ReadInt32();
            break;
          }
          case 26: {
            if (grantedRewards_ == null) {
              GrantedRewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
            }
            input.ReadMessage(GrantedRewards);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
