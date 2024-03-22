﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace FileUpload.Documents;
public class DocumentDto : EntityDto<Guid>
{
    public long FileSize { get; set; }

    public string FileUrl { get; set; }

    public string MimeType { get; set; }
}

