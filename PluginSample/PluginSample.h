#pragma once

//����cpp�t�@�C����export�̐ݒ������Ă���̂ŁA���̃w�b�_�[�͎g���Ă��Ȃ�

#ifndef INDLL_H
#define INDLL_H
#ifdef EXPORTING_DLL
//extern __declspec(dllexport) void *GetToken();
#else
//extern __declspec(dllimport) void *GetToken();
#endif
#endif
