I generated my test certificate with the following command:

makecert.exe -r -pe -n "CN=localhost" -ss my -sr LocalMachine -sky exchange -sp "Microsoft RSA SChannel Cryptographic Provider" -sy 12 LocalhostTestKey.cer

makecert.exe -r -pe -n "CN=BradTestClientKey" -ss my -sr CurrentUser -sky exchange -sp "Microsoft RSA SChannel Cryptographic Provider" -sy 12 BradTestClientKey.cer


Here's a good article on generating and using test certificates: http://www.aspnetpro.com/newsletterarticle/2006/10/asp200610mb_l/asp200610mb_l.asp