// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/StoryboardDoStepResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/StoryboardDoStepResponse.proto</summary>
  public static partial class StoryboardDoStepResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/StoryboardDoStepResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoryboardDoStepResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9TdG9yeWJvYXJkRG9T",
            "dGVwUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzGiNXVVByb3Rvcy9EYXRhL0xvb3QvTG9vdFJld2FyZC5wcm90byL3AwoY",
            "U3Rvcnlib2FyZERvU3RlcFJlc3BvbnNlEk4KBnN0YXR1cxgBIAEoDjI+LldV",
            "UHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlN0b3J5Ym9hcmREb1N0ZXBS",
            "ZXNwb25zZS5TdGF0dXMSPgoHcmV3YXJkcxgCIAEoCzItLldVUHJvdG9zLkRh",
            "dGEuTG9vdC5Mb290UmV3YXJkLkxvb3RDb2xsZWN0aW9uIsoCCgZTdGF0dXMS",
            "HgoaU1RPUllCT0FSRF9ET19TVEVQX1VOS05PV04QABIeChpTVE9SWUJPQVJE",
            "X0RPX1NURVBfU1VDQ0VTUxABEiYKIlNUT1JZQk9BUkRfRE9fU1RFUF9CQURf",
            "U1RFUF9OVU1CRVIQAhInCiNTVE9SWUJPQVJEX0RPX1NURVBfTk9fUkVTRVRf",
            "QUxMT1dFRBADEjAKLFNUT1JZQk9BUkRfRE9fU1RFUF9SRVNFVF9SRVFVSVJF",
            "TUVOVFNfRkFJTEVEEAQSMAosU1RPUllCT0FSRF9ET19TVEVQX1NUQVJUX1JF",
            "UVVJUkVNRU5UU19GQUlMRUQQBRIcChhTVE9SWUJPQVJEX0RPX1NURVBfRVJS",
            "T1IQBhItCilTVE9SWUJPQVJEX0RPX1NURVBfU1VDQ0VTU19BTkRfQ09NUExF",
            "VElPThAHYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.StoryboardDoStepResponse), global::WUProtos.Networking.Responses.StoryboardDoStepResponse.Parser, new[]{ "Status", "Rewards" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.StoryboardDoStepResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StoryboardDoStepResponse : pb::IMessage<StoryboardDoStepResponse> {
    private static readonly pb::MessageParser<StoryboardDoStepResponse> _parser = new pb::MessageParser<StoryboardDoStepResponse>(() => new StoryboardDoStepResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StoryboardDoStepResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.StoryboardDoStepResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryboardDoStepResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryboardDoStepResponse(StoryboardDoStepResponse other) : this() {
      status_ = other.status_;
      rewards_ = other.rewards_ != null ? other.rewards_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryboardDoStepResponse Clone() {
      return new StoryboardDoStepResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.StoryboardDoStepResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.StoryboardDoStepResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "rewards" field.</summary>
    public const int RewardsFieldNumber = 2;
    private global::WUProtos.Data.Loot.LootReward.Types.LootCollection rewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootReward.Types.LootCollection Rewards {
      get { return rewards_; }
      set {
        rewards_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StoryboardDoStepResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StoryboardDoStepResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(Rewards, other.Rewards)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (rewards_ != null) hash ^= Rewards.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (rewards_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Rewards);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (rewards_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rewards);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StoryboardDoStepResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.rewards_ != null) {
        if (rewards_ == null) {
          Rewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
        }
        Rewards.MergeFrom(other.Rewards);
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
            Status = (global::WUProtos.Networking.Responses.StoryboardDoStepResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (rewards_ == null) {
              Rewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
            }
            input.ReadMessage(Rewards);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the StoryboardDoStepResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("STORYBOARD_DO_STEP_UNKNOWN")] StoryboardDoStepUnknown = 0,
        [pbr::OriginalName("STORYBOARD_DO_STEP_SUCCESS")] StoryboardDoStepSuccess = 1,
        [pbr::OriginalName("STORYBOARD_DO_STEP_BAD_STEP_NUMBER")] StoryboardDoStepBadStepNumber = 2,
        [pbr::OriginalName("STORYBOARD_DO_STEP_NO_RESET_ALLOWED")] StoryboardDoStepNoResetAllowed = 3,
        [pbr::OriginalName("STORYBOARD_DO_STEP_RESET_REQUIREMENTS_FAILED")] StoryboardDoStepResetRequirementsFailed = 4,
        [pbr::OriginalName("STORYBOARD_DO_STEP_START_REQUIREMENTS_FAILED")] StoryboardDoStepStartRequirementsFailed = 5,
        [pbr::OriginalName("STORYBOARD_DO_STEP_ERROR")] StoryboardDoStepError = 6,
        [pbr::OriginalName("STORYBOARD_DO_STEP_SUCCESS_AND_COMPLETION")] StoryboardDoStepSuccessAndCompletion = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code