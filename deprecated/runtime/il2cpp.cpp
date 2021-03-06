#include <stdlib.h>
#include <thread>
#include "il2cpp.h"

#if defined(_WIN32)
#include <windows.h>
#else
#include <sys/types.h>
#endif

il2cppObject* il2cpp_New(uint32_t sz, uint32_t typeID)
{
	il2cppObject* obj = (il2cppObject*)calloc(1, sz);
	obj->objectTypeID = typeID;
	return obj;
}

void il2cpp_Yield()
{
#if defined(_WIN32)
	Sleep(0);
#else
	std::this_thread::yield();
#endif
}

uintptr_t il2cpp_ThreadID()
{
#if defined(_WIN32)
	return (uintptr_t)GetCurrentThreadId();
#else
	return (uintptr_t)gettid();
#endif
}

il2cppString* met_icall_System_Environment__GetResourceFromDefault(il2cppString* str)
{
	return nullptr;
}
