﻿using System;
using System.Threading.Tasks;
using ZhonTai.Common.Domain.Dto;
using ZhonTai.Plate.Admin.Service.Document.Input;

namespace ZhonTai.Plate.Admin.Service.Document
{
    public partial interface IDocumentService
    {
        Task<IResponseOutput> GetAsync(long id);

        Task<IResponseOutput> GetImageListAsync(long id);

        Task<IResponseOutput> GetGroupAsync(long id);

        Task<IResponseOutput> GetMenuAsync(long id);

        Task<IResponseOutput> GetContentAsync(long id);

        Task<IResponseOutput> GetPlainListAsync();

        Task<IResponseOutput> GetListAsync(string key, DateTime? start, DateTime? end);

        Task<IResponseOutput> AddGroupAsync(DocumentAddGroupInput input);

        Task<IResponseOutput> AddMenuAsync(DocumentAddMenuInput input);

        Task<IResponseOutput> AddImageAsync(DocumentAddImageInput input);

        Task<IResponseOutput> UpdateGroupAsync(DocumentUpdateGroupInput input);

        Task<IResponseOutput> UpdateMenuAsync(DocumentUpdateMenuInput input);

        Task<IResponseOutput> UpdateContentAsync(DocumentUpdateContentInput input);

        Task<IResponseOutput> DeleteAsync(long id);

        Task<IResponseOutput> DeleteImageAsync(long documentId, string url);

        Task<IResponseOutput> SoftDeleteAsync(long id);
    }
}