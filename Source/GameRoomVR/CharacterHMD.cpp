

#include "GameRoomVR.h"
#include "CharacterHMD.h"


ACharacterHMD::ACharacterHMD(const class FPostConstructInitializeProperties& PCIP)
	: Super(PCIP)
{
	DefaultPawnClass = ACharacterHMD::StaticClass();
}

void ACharacterHMD::BeginPlay()
{
	Super::BeginPlay();

	if (GEngine)
	{
		GEngine->AddOnScreenDebugMessage(-1, 5.f, FColor::Blue, TEXT("We are using FPSCharacter!"));
	}
}