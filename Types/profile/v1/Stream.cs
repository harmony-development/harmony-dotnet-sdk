// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: profile/v1/stream.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Harmony.Profile.V1 {

  /// <summary>Holder for reflection information generated from profile/v1/stream.proto</summary>
  public static partial class StreamReflection {

    #region Descriptor
    /// <summary>File descriptor for profile/v1/stream.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StreamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chdwcm9maWxlL3YxL3N0cmVhbS5wcm90bxITcHJvdG9jb2wucHJvZmlsZS52",
            "MRoWcHJvZmlsZS92MS90eXBlcy5wcm90byLmAQoOUHJvZmlsZVVwZGF0ZWQS",
            "DwoHdXNlcl9pZBgBIAEoBBIZCgxuZXdfdXNlcm5hbWUYAiABKAlIAIgBARIX",
            "CgpuZXdfYXZhdGFyGAMgASgJSAGIAQESOAoKbmV3X3N0YXR1cxgEIAEoDjIf",
            "LnByb3RvY29sLnByb2ZpbGUudjEuVXNlclN0YXR1c0gCiAEBEhcKCm5ld19p",
            "c19ib3QYBSABKAhIA4gBAUIPCg1fbmV3X3VzZXJuYW1lQg0KC19uZXdfYXZh",
            "dGFyQg0KC19uZXdfc3RhdHVzQg0KC19uZXdfaXNfYm90IlYKC1N0cmVhbUV2",
            "ZW50Ej4KD3Byb2ZpbGVfdXBkYXRlZBgOIAEoCzIjLnByb3RvY29sLnByb2Zp",
            "bGUudjEuUHJvZmlsZVVwZGF0ZWRIAEIHCgVldmVudGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Harmony.Profile.V1.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Harmony.Profile.V1.ProfileUpdated), global::Harmony.Profile.V1.ProfileUpdated.Parser, new[]{ "UserId", "NewUsername", "NewAvatar", "NewStatus", "NewIsBot" }, new[]{ "NewUsername", "NewAvatar", "NewStatus", "NewIsBot" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Harmony.Profile.V1.StreamEvent), global::Harmony.Profile.V1.StreamEvent.Parser, new[]{ "ProfileUpdated" }, new[]{ "Event" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Event sent when a user's profile is updated.
  ///
  /// Servers should sent this event only to users that can "see" (eg. they are
  /// in the same guild) the user this event was triggered by.
  /// </summary>
  public sealed partial class ProfileUpdated : pb::IMessage<ProfileUpdated>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProfileUpdated> _parser = new pb::MessageParser<ProfileUpdated>(() => new ProfileUpdated());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfileUpdated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Harmony.Profile.V1.StreamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfileUpdated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfileUpdated(ProfileUpdated other) : this() {
      _hasBits0 = other._hasBits0;
      userId_ = other.userId_;
      newUsername_ = other.newUsername_;
      newAvatar_ = other.newAvatar_;
      newStatus_ = other.newStatus_;
      newIsBot_ = other.newIsBot_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfileUpdated Clone() {
      return new ProfileUpdated(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private ulong userId_;
    /// <summary>
    /// User ID of the user that had it's profile updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "new_username" field.</summary>
    public const int NewUsernameFieldNumber = 2;
    private string newUsername_;
    /// <summary>
    /// New username for this user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NewUsername {
      get { return newUsername_ ?? ""; }
      set {
        newUsername_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "new_username" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasNewUsername {
      get { return newUsername_ != null; }
    }
    /// <summary>Clears the value of the "new_username" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearNewUsername() {
      newUsername_ = null;
    }

    /// <summary>Field number for the "new_avatar" field.</summary>
    public const int NewAvatarFieldNumber = 3;
    private string newAvatar_;
    /// <summary>
    /// New avatar for this user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NewAvatar {
      get { return newAvatar_ ?? ""; }
      set {
        newAvatar_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "new_avatar" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasNewAvatar {
      get { return newAvatar_ != null; }
    }
    /// <summary>Clears the value of the "new_avatar" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearNewAvatar() {
      newAvatar_ = null;
    }

    /// <summary>Field number for the "new_status" field.</summary>
    public const int NewStatusFieldNumber = 4;
    private global::Harmony.Profile.V1.UserStatus newStatus_;
    /// <summary>
    /// New status for this user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Harmony.Profile.V1.UserStatus NewStatus {
      get { if ((_hasBits0 & 1) != 0) { return newStatus_; } else { return global::Harmony.Profile.V1.UserStatus.OfflineUnspecified; } }
      set {
        _hasBits0 |= 1;
        newStatus_ = value;
      }
    }
    /// <summary>Gets whether the "new_status" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasNewStatus {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "new_status" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearNewStatus() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "new_is_bot" field.</summary>
    public const int NewIsBotFieldNumber = 5;
    private bool newIsBot_;
    /// <summary>
    /// New is bot or not for this user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NewIsBot {
      get { if ((_hasBits0 & 2) != 0) { return newIsBot_; } else { return false; } }
      set {
        _hasBits0 |= 2;
        newIsBot_ = value;
      }
    }
    /// <summary>Gets whether the "new_is_bot" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasNewIsBot {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "new_is_bot" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearNewIsBot() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfileUpdated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfileUpdated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (NewUsername != other.NewUsername) return false;
      if (NewAvatar != other.NewAvatar) return false;
      if (NewStatus != other.NewStatus) return false;
      if (NewIsBot != other.NewIsBot) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0UL) hash ^= UserId.GetHashCode();
      if (HasNewUsername) hash ^= NewUsername.GetHashCode();
      if (HasNewAvatar) hash ^= NewAvatar.GetHashCode();
      if (HasNewStatus) hash ^= NewStatus.GetHashCode();
      if (HasNewIsBot) hash ^= NewIsBot.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (UserId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(UserId);
      }
      if (HasNewUsername) {
        output.WriteRawTag(18);
        output.WriteString(NewUsername);
      }
      if (HasNewAvatar) {
        output.WriteRawTag(26);
        output.WriteString(NewAvatar);
      }
      if (HasNewStatus) {
        output.WriteRawTag(32);
        output.WriteEnum((int) NewStatus);
      }
      if (HasNewIsBot) {
        output.WriteRawTag(40);
        output.WriteBool(NewIsBot);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (UserId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(UserId);
      }
      if (HasNewUsername) {
        output.WriteRawTag(18);
        output.WriteString(NewUsername);
      }
      if (HasNewAvatar) {
        output.WriteRawTag(26);
        output.WriteString(NewAvatar);
      }
      if (HasNewStatus) {
        output.WriteRawTag(32);
        output.WriteEnum((int) NewStatus);
      }
      if (HasNewIsBot) {
        output.WriteRawTag(40);
        output.WriteBool(NewIsBot);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UserId);
      }
      if (HasNewUsername) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NewUsername);
      }
      if (HasNewAvatar) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NewAvatar);
      }
      if (HasNewStatus) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NewStatus);
      }
      if (HasNewIsBot) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfileUpdated other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0UL) {
        UserId = other.UserId;
      }
      if (other.HasNewUsername) {
        NewUsername = other.NewUsername;
      }
      if (other.HasNewAvatar) {
        NewAvatar = other.NewAvatar;
      }
      if (other.HasNewStatus) {
        NewStatus = other.NewStatus;
      }
      if (other.HasNewIsBot) {
        NewIsBot = other.NewIsBot;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            UserId = input.ReadUInt64();
            break;
          }
          case 18: {
            NewUsername = input.ReadString();
            break;
          }
          case 26: {
            NewAvatar = input.ReadString();
            break;
          }
          case 32: {
            NewStatus = (global::Harmony.Profile.V1.UserStatus) input.ReadEnum();
            break;
          }
          case 40: {
            NewIsBot = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            UserId = input.ReadUInt64();
            break;
          }
          case 18: {
            NewUsername = input.ReadString();
            break;
          }
          case 26: {
            NewAvatar = input.ReadString();
            break;
          }
          case 32: {
            NewStatus = (global::Harmony.Profile.V1.UserStatus) input.ReadEnum();
            break;
          }
          case 40: {
            NewIsBot = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Describes an emote service event.
  /// </summary>
  public sealed partial class StreamEvent : pb::IMessage<StreamEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StreamEvent> _parser = new pb::MessageParser<StreamEvent>(() => new StreamEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Harmony.Profile.V1.StreamReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamEvent(StreamEvent other) : this() {
      switch (other.EventCase) {
        case EventOneofCase.ProfileUpdated:
          ProfileUpdated = other.ProfileUpdated.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamEvent Clone() {
      return new StreamEvent(this);
    }

    /// <summary>Field number for the "profile_updated" field.</summary>
    public const int ProfileUpdatedFieldNumber = 14;
    /// <summary>
    /// Send the profile updated event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Harmony.Profile.V1.ProfileUpdated ProfileUpdated {
      get { return eventCase_ == EventOneofCase.ProfileUpdated ? (global::Harmony.Profile.V1.ProfileUpdated) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.ProfileUpdated;
      }
    }

    private object event_;
    /// <summary>Enum of possible cases for the "event" oneof.</summary>
    public enum EventOneofCase {
      None = 0,
      ProfileUpdated = 14,
    }
    private EventOneofCase eventCase_ = EventOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventOneofCase EventCase {
      get { return eventCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEvent() {
      eventCase_ = EventOneofCase.None;
      event_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProfileUpdated, other.ProfileUpdated)) return false;
      if (EventCase != other.EventCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (eventCase_ == EventOneofCase.ProfileUpdated) hash ^= ProfileUpdated.GetHashCode();
      hash ^= (int) eventCase_;
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (eventCase_ == EventOneofCase.ProfileUpdated) {
        output.WriteRawTag(114);
        output.WriteMessage(ProfileUpdated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (eventCase_ == EventOneofCase.ProfileUpdated) {
        output.WriteRawTag(114);
        output.WriteMessage(ProfileUpdated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (eventCase_ == EventOneofCase.ProfileUpdated) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfileUpdated);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StreamEvent other) {
      if (other == null) {
        return;
      }
      switch (other.EventCase) {
        case EventOneofCase.ProfileUpdated:
          if (ProfileUpdated == null) {
            ProfileUpdated = new global::Harmony.Profile.V1.ProfileUpdated();
          }
          ProfileUpdated.MergeFrom(other.ProfileUpdated);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 114: {
            global::Harmony.Profile.V1.ProfileUpdated subBuilder = new global::Harmony.Profile.V1.ProfileUpdated();
            if (eventCase_ == EventOneofCase.ProfileUpdated) {
              subBuilder.MergeFrom(ProfileUpdated);
            }
            input.ReadMessage(subBuilder);
            ProfileUpdated = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 114: {
            global::Harmony.Profile.V1.ProfileUpdated subBuilder = new global::Harmony.Profile.V1.ProfileUpdated();
            if (eventCase_ == EventOneofCase.ProfileUpdated) {
              subBuilder.MergeFrom(ProfileUpdated);
            }
            input.ReadMessage(subBuilder);
            ProfileUpdated = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code