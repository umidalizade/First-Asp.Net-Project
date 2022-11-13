﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CategoryRemove(Category category);
        //void CategoryUpdate(Category category);
        List<Comment> GetAllList(int id);
        //Category GetById(int id);
    }
}
