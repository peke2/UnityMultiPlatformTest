#pragma once

//今はcppファイルでexportの設定も入れているので、このヘッダーは使っていない

#ifndef INDLL_H
#define INDLL_H
#ifdef EXPORTING_DLL
//extern __declspec(dllexport) void *GetToken();
#else
//extern __declspec(dllimport) void *GetToken();
#endif
#endif
