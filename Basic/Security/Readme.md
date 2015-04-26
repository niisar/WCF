### Security
------
:key: In WCF there are two types of Security, :aerial_tramway: transport level security and :incoming_envelope: message level security.

:aerial_tramway: Transport Security:  Transport level security happens at the channel level. Transport level security is the easiest to implement as it happens at the communication level. WCF uses transport protocols like TCP, HTTP, MSMQ etc and every of these protocols have their own security mechanisms. One of the common implementation of transport level security is HTTPS. HTTPS is implemented over HTTP protocols with SSL providing the security mechanism. No coding change is required it’s more of using the existing security mechanism provided by the protocol.

:incoming_envelope: Message Security: Message level security is implemented with message data itself. Due to this it is independent of the protocol. Some of the common ways of implementing message level security is by encrypting data using some standard encryption algorithm.