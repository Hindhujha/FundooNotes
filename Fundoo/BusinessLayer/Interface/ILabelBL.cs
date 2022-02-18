﻿using CommonLayer.LabelModel;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public  interface ILabelBL
    {
        Task<List<Label>> CreateLabel(LabelPostModel labelModel, int NotesId, int UserId);

        public bool UpdateLabel(int LabelId, LabelPostModel labelPost);


        public bool DeleteLabel(int LabelId);


        Task<List<Label>> GetAllDatas(int UserId);
    }
}
