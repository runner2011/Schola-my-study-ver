#include "ScholaMimic.h"

#define LOCTEXT_NAMESPACE "FScholaMimicModule"

DEFINE_LOG_CATEGORY(LogScholaMimic);

void FScholaMimicModule::StartupModule()
{
    UE_LOG(LogScholaMimic, Display, TEXT("Schola Mimic runtime module started"));
}

void FScholaMimicModule::ShutdownModule()
{
    UE_LOG(LogScholaMimic, Display, TEXT("Schola Mimic runtime module stopped"));
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FScholaMimicModule, ScholaMimic)
