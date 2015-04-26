### Security
------
In WCF there are two types of :key: Security, :aerial_tramway: transport level security and :incoming_envelope: message level security.

:aerial_tramway: Transport Security:  Transport level security happens at the :cl: channel level. Transport level security is the easiest to implement as it happens at the :cl: communication level. WCF uses transport protocols like TCP, HTTP, MSMQ etc and every of these protocols have their own security mechanisms. One of the common implementation of transport level security is HTTPS. HTTPS is implemented over HTTP protocols with SSL providing the security mechanism. No coding change is required it’s more of using the existing security mechanism provided by the protocol.

:incoming_envelope: Message Security: Message level security is implemented with message data itself. Due to this it is independent of the protocol. Some of the common ways of implementing message level security is by encrypting data using some standard encryption algorithm.

The WCF security mode that are available are as follows:

- None
- Transport
- Message
- Both
- TransportWithMessageCredential
- TransportCredentialOnly

##### Common Binding and their supported modes:

Binding name | None | Transport | Message | Mixed | Both
-- | -- | -- | -- | -- | -- |
basicHttpBinding | :heavy_check_mark: :white_circle: | :heavy_check_mark: | :heavy_check_mark:| :heavy_check_mark:| :x: |
netTCPBinding | :heavy_check_mark: | :heavy_check_mark: :white_circle:|:heavy_check_mark:|:heavy_check_mark:| :x: |
netPeerTCPBinding | :heavy_check_mark: | :heavy_check_mark: :white_circle: | :heavy_check_mark: | :heavy_check_mark: | :x: |
netNamedPipeBinding | :heavy_check_mark: | :heavy_check_mark: :white_circle: | :x: | :x: | :x: |
wsHttpBinding | :heavy_check_mark: | :heavy_check_mark: |:heavy_check_mark: :white_circle:|:heavy_check_mark: | :x: |
wsFederationHttpBinding | :heavy_check_mark: | :x: | :heavy_check_mark: :white_circle: | :x: | :x: |
wsDualHttpBinding | :heavy_check_mark: | :x: | :heavy_check_mark: :white_circle: | :x: | :x: |
netMsmqBinding | :heavy_check_mark: | :heavy_check_mark: :white_circle: | :heavy_check_mark: | :x: | :heavy_check_mark: |

