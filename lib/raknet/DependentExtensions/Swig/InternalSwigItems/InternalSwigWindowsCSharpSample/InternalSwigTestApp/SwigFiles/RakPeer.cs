/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class RakPeer : RakPeerInterface {
  private HandleRef swigCPtr;

  internal RakPeer(IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.RakPeer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakPeer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakPeer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakPeer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	public override void GetIncomingPassword(ref string passwordData, ref int passwordDataLength  )
	{
		passwordData=CSharpGetIncomingPasswordHelper(passwordData,ref passwordDataLength);
	}

	public override void GetOfflinePingResponse( byte[] inOutByteArray, out uint length )
	{
		CSharpGetOfflinePingResponseHelper(inOutByteArray,out length);
	}

	public override bool GetConnectionList(out SystemAddress[] remoteSystems, ref ushort numberOfSystems)
	{
		RakNetListSystemAddress passVal= new RakNetListSystemAddress();
		bool returnVal = GetConnectionList(passVal,ref numberOfSystems);
		SystemAddress[] outVal = new SystemAddress[numberOfSystems];
		for (int i=0; i<numberOfSystems;i++)
		{
			outVal[i]=passVal[i];
		} 
		remoteSystems=outVal;
		return returnVal;
	}


  public RakPeer() : this(RakNetPINVOKE.new_RakPeer(), true) {
  }

  public override StartupResult Startup(ushort maxConnections, SocketDescriptor socketDescriptors, uint socketDescriptorCount, int threadPriority) {
    StartupResult ret = (StartupResult)RakNetPINVOKE.RakPeer_Startup__SWIG_0(swigCPtr, maxConnections, SocketDescriptor.getCPtr(socketDescriptors), socketDescriptorCount, threadPriority);
    return ret;
  }

  public override StartupResult Startup(ushort maxConnections, SocketDescriptor socketDescriptors, uint socketDescriptorCount) {
    StartupResult ret = (StartupResult)RakNetPINVOKE.RakPeer_Startup__SWIG_1(swigCPtr, maxConnections, SocketDescriptor.getCPtr(socketDescriptors), socketDescriptorCount);
    return ret;
  }

  public override bool InitializeSecurity(string publicKey, string privateKey, bool bRequireClientKey) {
    bool ret = RakNetPINVOKE.RakPeer_InitializeSecurity__SWIG_0(swigCPtr, publicKey, privateKey, bRequireClientKey);
    return ret;
  }

  public override bool InitializeSecurity(string publicKey, string privateKey) {
    bool ret = RakNetPINVOKE.RakPeer_InitializeSecurity__SWIG_1(swigCPtr, publicKey, privateKey);
    return ret;
  }

  public override void DisableSecurity() {
    RakNetPINVOKE.RakPeer_DisableSecurity(swigCPtr);
  }

  public override void AddToSecurityExceptionList(string ip) {
    RakNetPINVOKE.RakPeer_AddToSecurityExceptionList(swigCPtr, ip);
  }

  public override void RemoveFromSecurityExceptionList(string ip) {
    RakNetPINVOKE.RakPeer_RemoveFromSecurityExceptionList(swigCPtr, ip);
  }

  public override bool IsInSecurityExceptionList(string ip) {
    bool ret = RakNetPINVOKE.RakPeer_IsInSecurityExceptionList(swigCPtr, ip);
    return ret;
  }

  public override void SetMaximumIncomingConnections(ushort numberAllowed) {
    RakNetPINVOKE.RakPeer_SetMaximumIncomingConnections(swigCPtr, numberAllowed);
  }

  public override ushort GetMaximumIncomingConnections() {
    ushort ret = RakNetPINVOKE.RakPeer_GetMaximumIncomingConnections(swigCPtr);
    return ret;
  }

  public override ushort NumberOfConnections() {
    ushort ret = RakNetPINVOKE.RakPeer_NumberOfConnections(swigCPtr);
    return ret;
  }

  public override void SetIncomingPassword(string passwordData, int passwordDataLength) {
    RakNetPINVOKE.RakPeer_SetIncomingPassword__SWIG_0(swigCPtr, passwordData, passwordDataLength);
  }

  public override ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex, uint sendConnectionAttemptCount, uint timeBetweenSendConnectionAttemptsMS, uint timeoutTime) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeer_Connect__SWIG_0(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex, sendConnectionAttemptCount, timeBetweenSendConnectionAttemptsMS, timeoutTime);
    return ret;
  }

  public override ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex, uint sendConnectionAttemptCount, uint timeBetweenSendConnectionAttemptsMS) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeer_Connect__SWIG_1(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex, sendConnectionAttemptCount, timeBetweenSendConnectionAttemptsMS);
    return ret;
  }

  public override ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex, uint sendConnectionAttemptCount) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeer_Connect__SWIG_2(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex, sendConnectionAttemptCount);
    return ret;
  }

  public override ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeer_Connect__SWIG_3(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex);
    return ret;
  }

  public override ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeer_Connect__SWIG_4(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey));
    return ret;
  }

  public override ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeer_Connect__SWIG_5(swigCPtr, host, remotePort, passwordData, passwordDataLength);
    return ret;
  }

  public override void Shutdown(uint blockDuration, byte orderingChannel, PacketPriority disconnectionNotificationPriority) {
    RakNetPINVOKE.RakPeer_Shutdown__SWIG_0(swigCPtr, blockDuration, orderingChannel, (int)disconnectionNotificationPriority);
  }

  public override void Shutdown(uint blockDuration, byte orderingChannel) {
    RakNetPINVOKE.RakPeer_Shutdown__SWIG_1(swigCPtr, blockDuration, orderingChannel);
  }

  public override void Shutdown(uint blockDuration) {
    RakNetPINVOKE.RakPeer_Shutdown__SWIG_2(swigCPtr, blockDuration);
  }

  public override bool IsActive() {
    bool ret = RakNetPINVOKE.RakPeer_IsActive(swigCPtr);
    return ret;
  }

  public override uint GetNextSendReceipt() {
    uint ret = RakNetPINVOKE.RakPeer_GetNextSendReceipt(swigCPtr);
    return ret;
  }

  public override uint IncrementNextSendReceipt() {
    uint ret = RakNetPINVOKE.RakPeer_IncrementNextSendReceipt(swigCPtr);
    return ret;
  }

  public override uint Send(string data, int length, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast, uint forceReceiptNumber) {
    uint ret = RakNetPINVOKE.RakPeer_Send__SWIG_0(swigCPtr, data, length, (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast, forceReceiptNumber);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint Send(string data, int length, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast) {
    uint ret = RakNetPINVOKE.RakPeer_Send__SWIG_1(swigCPtr, data, length, (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SendLoopback(string data, int length) {
    RakNetPINVOKE.RakPeer_SendLoopback__SWIG_0(swigCPtr, data, length);
  }

  public override uint Send(BitStream bitStream, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast, uint forceReceiptNumber) {
    uint ret = RakNetPINVOKE.RakPeer_Send__SWIG_2(swigCPtr, BitStream.getCPtr(bitStream), (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast, forceReceiptNumber);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint Send(BitStream bitStream, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast) {
    uint ret = RakNetPINVOKE.RakPeer_Send__SWIG_3(swigCPtr, BitStream.getCPtr(bitStream), (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Packet Receive() {
    IntPtr cPtr = RakNetPINVOKE.RakPeer_Receive(swigCPtr);
    Packet ret = (cPtr == IntPtr.Zero) ? null : new Packet(cPtr, false);
    return ret;
  }

  public override void DeallocatePacket(Packet packet) {
    RakNetPINVOKE.RakPeer_DeallocatePacket(swigCPtr, Packet.getCPtr(packet));
  }

  public override ushort GetMaximumNumberOfPeers() {
    ushort ret = RakNetPINVOKE.RakPeer_GetMaximumNumberOfPeers(swigCPtr);
    return ret;
  }

  public override void CloseConnection(AddressOrGUID target, bool sendDisconnectionNotification, byte orderingChannel, PacketPriority disconnectionNotificationPriority) {
    RakNetPINVOKE.RakPeer_CloseConnection__SWIG_0(swigCPtr, AddressOrGUID.getCPtr(target), sendDisconnectionNotification, orderingChannel, (int)disconnectionNotificationPriority);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void CloseConnection(AddressOrGUID target, bool sendDisconnectionNotification, byte orderingChannel) {
    RakNetPINVOKE.RakPeer_CloseConnection__SWIG_1(swigCPtr, AddressOrGUID.getCPtr(target), sendDisconnectionNotification, orderingChannel);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void CloseConnection(AddressOrGUID target, bool sendDisconnectionNotification) {
    RakNetPINVOKE.RakPeer_CloseConnection__SWIG_2(swigCPtr, AddressOrGUID.getCPtr(target), sendDisconnectionNotification);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void CancelConnectionAttempt(SystemAddress target) {
    RakNetPINVOKE.RakPeer_CancelConnectionAttempt(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ConnectionState GetConnectionState(AddressOrGUID systemIdentifier) {
    ConnectionState ret = (ConnectionState)RakNetPINVOKE.RakPeer_GetConnectionState(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetIndexFromSystemAddress(SystemAddress systemAddress) {
    int ret = RakNetPINVOKE.RakPeer_GetIndexFromSystemAddress(swigCPtr, SystemAddress.getCPtr(systemAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SystemAddress GetSystemAddressFromIndex(int index) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetSystemAddressFromIndex(swigCPtr, index), true);
    return ret;
  }

  public override RakNetGUID GetGUIDFromIndex(int index) {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.RakPeer_GetGUIDFromIndex(swigCPtr, index), true);
    return ret;
  }

  public override void GetSystemList(RakNetListSystemAddress addresses, RakNetListRakNetGUID guids) {
    RakNetPINVOKE.RakPeer_GetSystemList(swigCPtr, RakNetListSystemAddress.getCPtr(addresses), RakNetListRakNetGUID.getCPtr(guids));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddToBanList(string IP, uint milliseconds) {
    RakNetPINVOKE.RakPeer_AddToBanList__SWIG_0(swigCPtr, IP, milliseconds);
  }

  public override void AddToBanList(string IP) {
    RakNetPINVOKE.RakPeer_AddToBanList__SWIG_1(swigCPtr, IP);
  }

  public override void RemoveFromBanList(string IP) {
    RakNetPINVOKE.RakPeer_RemoveFromBanList(swigCPtr, IP);
  }

  public override void ClearBanList() {
    RakNetPINVOKE.RakPeer_ClearBanList(swigCPtr);
  }

  public override bool IsBanned(string IP) {
    bool ret = RakNetPINVOKE.RakPeer_IsBanned(swigCPtr, IP);
    return ret;
  }

  public override void SetLimitIPConnectionFrequency(bool b) {
    RakNetPINVOKE.RakPeer_SetLimitIPConnectionFrequency(swigCPtr, b);
  }

  public override void Ping(SystemAddress target) {
    RakNetPINVOKE.RakPeer_Ping__SWIG_0(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool Ping(string host, ushort remotePort, bool onlyReplyOnAcceptingConnections, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeer_Ping__SWIG_1(swigCPtr, host, remotePort, onlyReplyOnAcceptingConnections, connectionSocketIndex);
    return ret;
  }

  public override bool Ping(string host, ushort remotePort, bool onlyReplyOnAcceptingConnections) {
    bool ret = RakNetPINVOKE.RakPeer_Ping__SWIG_2(swigCPtr, host, remotePort, onlyReplyOnAcceptingConnections);
    return ret;
  }

  public override int GetAveragePing(AddressOrGUID systemIdentifier) {
    int ret = RakNetPINVOKE.RakPeer_GetAveragePing(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetLastPing(AddressOrGUID systemIdentifier) {
    int ret = RakNetPINVOKE.RakPeer_GetLastPing(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetLowestPing(AddressOrGUID systemIdentifier) {
    int ret = RakNetPINVOKE.RakPeer_GetLowestPing(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetOccasionalPing(bool doPing) {
    RakNetPINVOKE.RakPeer_SetOccasionalPing(swigCPtr, doPing);
  }

  public override void SetOfflinePingResponse(string data, uint length) {
    RakNetPINVOKE.RakPeer_SetOfflinePingResponse__SWIG_0(swigCPtr, data, length);
  }

  public override SystemAddress GetInternalID(SystemAddress systemAddress, int index) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetInternalID__SWIG_0(swigCPtr, SystemAddress.getCPtr(systemAddress), index), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SystemAddress GetInternalID(SystemAddress systemAddress) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetInternalID__SWIG_1(swigCPtr, SystemAddress.getCPtr(systemAddress)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SystemAddress GetInternalID() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetInternalID__SWIG_2(swigCPtr), true);
    return ret;
  }

  public override SystemAddress GetExternalID(SystemAddress target) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetExternalID(swigCPtr, SystemAddress.getCPtr(target)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override RakNetGUID GetMyGUID() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.RakPeer_GetMyGUID(swigCPtr), true);
    return ret;
  }

  public override SystemAddress GetMyBoundAddress(int socketIndex) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetMyBoundAddress__SWIG_0(swigCPtr, socketIndex), true);
    return ret;
  }

  public override SystemAddress GetMyBoundAddress() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetMyBoundAddress__SWIG_1(swigCPtr), true);
    return ret;
  }

  public override RakNetGUID GetGuidFromSystemAddress(SystemAddress input) {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.RakPeer_GetGuidFromSystemAddress(swigCPtr, SystemAddress.getCPtr(input)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SystemAddress GetSystemAddressFromGuid(RakNetGUID input) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeer_GetSystemAddressFromGuid(swigCPtr, RakNetGUID.getCPtr(input)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool GetClientPublicKeyFromSystemAddress(SystemAddress input, string client_public_key) {
    bool ret = RakNetPINVOKE.RakPeer_GetClientPublicKeyFromSystemAddress(swigCPtr, SystemAddress.getCPtr(input), client_public_key);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetTimeoutTime(uint timeMS, SystemAddress target) {
    RakNetPINVOKE.RakPeer_SetTimeoutTime(swigCPtr, timeMS, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint GetTimeoutTime(SystemAddress target) {
    uint ret = RakNetPINVOKE.RakPeer_GetTimeoutTime(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetMTUSize(SystemAddress target) {
    int ret = RakNetPINVOKE.RakPeer_GetMTUSize(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint GetNumberOfAddresses() {
    uint ret = RakNetPINVOKE.RakPeer_GetNumberOfAddresses(swigCPtr);
    return ret;
  }

  public override string GetLocalIP(uint index) {
    string ret = RakNetPINVOKE.RakPeer_GetLocalIP(swigCPtr, index);
    return ret;
  }

  public override bool IsLocalIP(string ip) {
    bool ret = RakNetPINVOKE.RakPeer_IsLocalIP(swigCPtr, ip);
    return ret;
  }

  public override void AllowConnectionResponseIPMigration(bool allow) {
    RakNetPINVOKE.RakPeer_AllowConnectionResponseIPMigration(swigCPtr, allow);
  }

  public override bool AdvertiseSystem(string host, ushort remotePort, string data, int dataLength, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeer_AdvertiseSystem__SWIG_0(swigCPtr, host, remotePort, data, dataLength, connectionSocketIndex);
    return ret;
  }

  public override bool AdvertiseSystem(string host, ushort remotePort, string data, int dataLength) {
    bool ret = RakNetPINVOKE.RakPeer_AdvertiseSystem__SWIG_1(swigCPtr, host, remotePort, data, dataLength);
    return ret;
  }

  public override void SetSplitMessageProgressInterval(int interval) {
    RakNetPINVOKE.RakPeer_SetSplitMessageProgressInterval(swigCPtr, interval);
  }

  public override int GetSplitMessageProgressInterval() {
    int ret = RakNetPINVOKE.RakPeer_GetSplitMessageProgressInterval(swigCPtr);
    return ret;
  }

  public override void SetUnreliableTimeout(uint timeoutMS) {
    RakNetPINVOKE.RakPeer_SetUnreliableTimeout(swigCPtr, timeoutMS);
  }

  public override void SendTTL(string host, ushort remotePort, int ttl, uint connectionSocketIndex) {
    RakNetPINVOKE.RakPeer_SendTTL__SWIG_0(swigCPtr, host, remotePort, ttl, connectionSocketIndex);
  }

  public override void SendTTL(string host, ushort remotePort, int ttl) {
    RakNetPINVOKE.RakPeer_SendTTL__SWIG_1(swigCPtr, host, remotePort, ttl);
  }

  public override void AttachPlugin(PluginInterface2 plugin) {
    RakNetPINVOKE.RakPeer_AttachPlugin(swigCPtr, PluginInterface2.getCPtr(plugin));
  }

  public override void DetachPlugin(PluginInterface2 messageHandler) {
    RakNetPINVOKE.RakPeer_DetachPlugin(swigCPtr, PluginInterface2.getCPtr(messageHandler));
  }

  public override void PushBackPacket(Packet packet, bool pushAtHead) {
    RakNetPINVOKE.RakPeer_PushBackPacket(swigCPtr, Packet.getCPtr(packet), pushAtHead);
  }

  public override void ChangeSystemAddress(RakNetGUID guid, SystemAddress systemAddress) {
    RakNetPINVOKE.RakPeer_ChangeSystemAddress(swigCPtr, RakNetGUID.getCPtr(guid), SystemAddress.getCPtr(systemAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override Packet AllocatePacket(uint dataSize) {
    IntPtr cPtr = RakNetPINVOKE.RakPeer_AllocatePacket(swigCPtr, dataSize);
    Packet ret = (cPtr == IntPtr.Zero) ? null : new Packet(cPtr, false);
    return ret;
  }

  public override void WriteOutOfBandHeader(BitStream bitStream) {
    RakNetPINVOKE.RakPeer_WriteOutOfBandHeader(swigCPtr, BitStream.getCPtr(bitStream));
  }

  public override void ApplyNetworkSimulator(float packetloss, ushort minExtraPing, ushort extraPingVariance) {
    RakNetPINVOKE.RakPeer_ApplyNetworkSimulator(swigCPtr, packetloss, minExtraPing, extraPingVariance);
  }

  public override void SetPerConnectionOutgoingBandwidthLimit(uint maxBitsPerSecond) {
    RakNetPINVOKE.RakPeer_SetPerConnectionOutgoingBandwidthLimit(swigCPtr, maxBitsPerSecond);
  }

  public override bool IsNetworkSimulatorActive() {
    bool ret = RakNetPINVOKE.RakPeer_IsNetworkSimulatorActive(swigCPtr);
    return ret;
  }

  public override RakNetStatistics GetStatistics(SystemAddress systemAddress, RakNetStatistics rns) {
    IntPtr cPtr = RakNetPINVOKE.RakPeer_GetStatistics__SWIG_0(swigCPtr, SystemAddress.getCPtr(systemAddress), RakNetStatistics.getCPtr(rns));
    RakNetStatistics ret = (cPtr == IntPtr.Zero) ? null : new RakNetStatistics(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override RakNetStatistics GetStatistics(SystemAddress systemAddress) {
    IntPtr cPtr = RakNetPINVOKE.RakPeer_GetStatistics__SWIG_1(swigCPtr, SystemAddress.getCPtr(systemAddress));
    RakNetStatistics ret = (cPtr == IntPtr.Zero) ? null : new RakNetStatistics(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool GetStatistics(int index, RakNetStatistics rns) {
    bool ret = RakNetPINVOKE.RakPeer_GetStatistics__SWIG_2(swigCPtr, index, RakNetStatistics.getCPtr(rns));
    return ret;
  }

  public override uint GetReceiveBufferSize() {
    uint ret = RakNetPINVOKE.RakPeer_GetReceiveBufferSize(swigCPtr);
    return ret;
  }

  public override bool SendOutOfBand(string host, ushort remotePort, string data, uint dataLength, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeer_SendOutOfBand__SWIG_0(swigCPtr, host, remotePort, data, dataLength, connectionSocketIndex);
    return ret;
  }

  public override bool SendOutOfBand(string host, ushort remotePort, string data, uint dataLength) {
    bool ret = RakNetPINVOKE.RakPeer_SendOutOfBand__SWIG_1(swigCPtr, host, remotePort, data, dataLength);
    return ret;
  }

  public new uint Send(byte[] inByteArray, int length, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast) {
    uint ret = RakNetPINVOKE.RakPeer_Send__SWIG_4(swigCPtr, inByteArray, length, (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new void SendLoopback(byte[] inByteArray, int length) {
    RakNetPINVOKE.RakPeer_SendLoopback__SWIG_1(swigCPtr, inByteArray, length);
  }

  public new void SetOfflinePingResponse(byte[] inByteArray, uint length) {
    RakNetPINVOKE.RakPeer_SetOfflinePingResponse__SWIG_1(swigCPtr, inByteArray, length);
  }

  public new bool AdvertiseSystem(string host, ushort remotePort, byte[] inByteArray, int dataLength, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeer_AdvertiseSystem__SWIG_2(swigCPtr, host, remotePort, inByteArray, dataLength, connectionSocketIndex);
    return ret;
  }

  public new bool AdvertiseSystem(string host, ushort remotePort, byte[] inByteArray, int dataLength) {
    bool ret = RakNetPINVOKE.RakPeer_AdvertiseSystem__SWIG_3(swigCPtr, host, remotePort, inByteArray, dataLength);
    return ret;
  }

  private string CSharpGetIncomingPasswordHelper(string passwordData, ref int passwordDataLength) {
    string ret = RakNetPINVOKE.RakPeer_CSharpGetIncomingPasswordHelper(swigCPtr, passwordData, ref passwordDataLength);
    return ret;
  }

  public new void SetIncomingPassword(byte[] passwordDataByteArray, int passwordDataLength) {
    RakNetPINVOKE.RakPeer_SetIncomingPassword__SWIG_1(swigCPtr, passwordDataByteArray, passwordDataLength);
  }

  public new void GetIncomingPassword(byte[] passwordDataByteArray, ref int passwordDataLength) {
    RakNetPINVOKE.RakPeer_GetIncomingPassword(swigCPtr, passwordDataByteArray, ref passwordDataLength);
  }

  private void CSharpGetOfflinePingResponseHelper(byte[] inOutByteArray, out uint outLength) {
    RakNetPINVOKE.RakPeer_CSharpGetOfflinePingResponseHelper(swigCPtr, inOutByteArray, out outLength);
  }

  public new bool GetConnectionList(RakNetListSystemAddress remoteSystems, ref ushort numberOfSystems) {
    bool ret = RakNetPINVOKE.RakPeer_GetConnectionList(swigCPtr, RakNetListSystemAddress.getCPtr(remoteSystems), ref numberOfSystems);
    return ret;
  }

}

}
