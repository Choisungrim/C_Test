{ pkgs }: {
	deps = [
   pkgs.mono
   pkgs.haskellPackages.tangle
		pkgs.jq.bin
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}