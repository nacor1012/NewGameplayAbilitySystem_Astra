// Copyright SkyHigh Gaming.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "AstraCharacterBase.generated.h"

UCLASS(Abstract)
class ASTRAPROJECT02_API AAstraCharacterBase : public ACharacter
{
	GENERATED_BODY()

public:

	AAstraCharacterBase();

protected:
	
	virtual void BeginPlay() override;

};
