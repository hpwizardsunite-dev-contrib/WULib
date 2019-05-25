// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/ClaimPotionMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/ClaimPotionMessage.proto</summary>
  public static partial class ClaimPotionMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/ClaimPotionMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClaimPotionMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5XVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0NsYWlt",
            "UG90aW9uTWVzc2FnZS5wcm90bxIlV1VQcm90b3MuTmV0d29ya2luZy5SZXF1",
            "ZXN0cy5NZXNzYWdlcxojV1VQcm90b3MvRGF0YS9Mb290L0xvb3RSZXdhcmQu",
            "cHJvdG8iigEKEkNsYWltUG90aW9uTWVzc2FnZRITCgtjYXVsZHJvbl9pZBgB",
            "IAEoAxIVCg1jYXVsZHJvbl9zbG90GAIgASgFEkgKEXJlcXVlc3RlZF9yZXdh",
            "cmRzGAMgASgLMi0uV1VQcm90b3MuRGF0YS5Mb290Lkxvb3RSZXdhcmQuTG9v",
            "dENvbGxlY3Rpb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.ClaimPotionMessage), global::WUProtos.Networking.Requests.Messages.ClaimPotionMessage.Parser, new[]{ "CauldronId", "CauldronSlot", "RequestedRewards" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClaimPotionMessage : pb::IMessage<ClaimPotionMessage> {
    private static readonly pb::MessageParser<ClaimPotionMessage> _parser = new pb::MessageParser<ClaimPotionMessage>(() => new ClaimPotionMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClaimPotionMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.ClaimPotionMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimPotionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimPotionMessage(ClaimPotionMessage other) : this() {
      cauldronId_ = other.cauldronId_;
      cauldronSlot_ = other.cauldronSlot_;
      requestedRewards_ = other.requestedRewards_ != null ? other.requestedRewards_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimPotionMessage Clone() {
      return new ClaimPotionMessage(this);
    }

    /// <summary>Field number for the "cauldron_id" field.</summary>
    public const int CauldronIdFieldNumber = 1;
    private long cauldronId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CauldronId {
      get { return cauldronId_; }
      set {
        cauldronId_ = value;
      }
    }

    /// <summary>Field number for the "cauldron_slot" field.</summary>
    public const int CauldronSlotFieldNumber = 2;
    private int cauldronSlot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CauldronSlot {
      get { return cauldronSlot_; }
      set {
        cauldronSlot_ = value;
      }
    }

    /// <summary>Field number for the "requested_rewards" field.</summary>
    public const int RequestedRewardsFieldNumber = 3;
    private global::WUProtos.Data.Loot.LootReward.Types.LootCollection requestedRewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootReward.Types.LootCollection RequestedRewards {
      get { return requestedRewards_; }
      set {
        requestedRewards_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClaimPotionMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClaimPotionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CauldronId != other.CauldronId) return false;
      if (CauldronSlot != other.CauldronSlot) return false;
      if (!object.Equals(RequestedRewards, other.RequestedRewards)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CauldronId != 0L) hash ^= CauldronId.GetHashCode();
      if (CauldronSlot != 0) hash ^= CauldronSlot.GetHashCode();
      if (requestedRewards_ != null) hash ^= RequestedRewards.GetHashCode();
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
      if (CauldronId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CauldronId);
      }
      if (CauldronSlot != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CauldronSlot);
      }
      if (requestedRewards_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RequestedRewards);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CauldronId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CauldronId);
      }
      if (CauldronSlot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CauldronSlot);
      }
      if (requestedRewards_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RequestedRewards);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClaimPotionMessage other) {
      if (other == null) {
        return;
      }
      if (other.CauldronId != 0L) {
        CauldronId = other.CauldronId;
      }
      if (other.CauldronSlot != 0) {
        CauldronSlot = other.CauldronSlot;
      }
      if (other.requestedRewards_ != null) {
        if (requestedRewards_ == null) {
          RequestedRewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
        }
        RequestedRewards.MergeFrom(other.RequestedRewards);
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
            CauldronId = input.ReadInt64();
            break;
          }
          case 16: {
            CauldronSlot = input.ReadInt32();
            break;
          }
          case 26: {
            if (requestedRewards_ == null) {
              RequestedRewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
            }
            input.ReadMessage(RequestedRewards);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
