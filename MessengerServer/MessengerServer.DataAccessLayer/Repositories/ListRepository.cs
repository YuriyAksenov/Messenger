﻿using MessengerServer.DataAccessLayer.EntityFramework;
using MessengerServer.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerServer.DataAccessLayer.Repositories
{
    public class ListRepository : IListRepository
    {
        private MessengerContext db;

        public ListRepository(MessengerContext context)
        {
            this.db = context;
        }

        public void Create(List list)
        {
            db.Lists.Add(list);
            //try
            //{
            //    SqlParameter title = new SqlParameter("@title", item.Title);
            //    SqlParameter comment = new SqlParameter("@comment", item.Comment);
            //    SqlParameter creatorId = new SqlParameter("@creatorId", item.CreatorId);
            //    SqlParameter creationDate = new SqlParameter("@creationDate", item.CreationDate);
            //    SqlParameter modificationDate = new SqlParameter("@modificationDate", item.ModificationDate);
            //    SqlParameter notRelevant = new SqlParameter("@notRelevant", item.NotRelevant);

            //    db.Database.SqlQuery<int>("List_InsertList @title, @comment, @creatorId, @creationDate, @modificationDate, @notRelevant",
            //                                              title, comment, creatorId, creationDate, modificationDate, notRelevant).FirstOrDefault();
            //}
            //catch (SqlException e)
            //{
            //    Console.Write("SqlException " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.Write(" " + e.Message);
            //}
        }

        public void Delete(int id)
        {
            List list = db.Lists.Find(id);
            if (list != null)
                db.Lists.Remove(list); ;
        }

        public IEnumerable<List> Find(Func<List, bool> predicate)
        {
            return db.Lists.Where(predicate).ToList();
        }

        public List Get(int id)
        {
            return db.Lists.Find(id);
            //try
            //{
            //    SqlParameter listId = new SqlParameter("@listId", id);
            //    var list =  db.Database.SqlQuery<List>("SELECT * FROM List_GetListByListId(@listId)", listId).FirstOrDefault();
            //    return (list);
            //}
            //catch (SqlException e)
            //{
            //    Console.Write("SqlException " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.Write(" " + e.Message);
            //}

            //return null;
        }

        public List Get(string title, int creatorId)
        {
            try
            {
                SqlParameter _title = new SqlParameter("@title", title);
                SqlParameter _creatorId = new SqlParameter("@creatorId", creatorId);
                var list =  db.Database.SqlQuery<List>("SELECT * FROM List_GetListByTitleAndCreatorId(@title, @creatorId)", _title, _creatorId).FirstOrDefault();
                return (list);
            }
            catch (SqlException e)
            {
                Console.Write("SqlException " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(" " + e.Message);
            }

            return null;
        }

        public int? GetListIdByTitleAndContactId(string title, int creatorId)
        {
            try
            {
                SqlParameter _title = new SqlParameter("@title", title);
                SqlParameter _creatorId = new SqlParameter("@creatorId", creatorId);
                var list =  db.Database.SqlQuery<int>("SELECT [dbo].[List_GetListIdByTitleAndCreatorId](@title, @creatorId)", _title, _creatorId).FirstOrDefault();
                return (list);
            }
            catch (SqlException e)
            {
                Console.Write("SqlException " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(" " + e.Message);
            }

            return null;
        }

        public IEnumerable<List> GetAll()
        {
            return db.Lists;
        }

        public List<Contact> GetListOfFriendsByContactId(int contactId)
        {
            try
            {
                SqlParameter _contactId = new SqlParameter("@contactId", contactId);
                var friends =  db.Database.SqlQuery<Contact>("SELECT * FROM List_GetListOfFriendsByContactId(@contactId)", _contactId).ToList();
                return (friends);
            }
            catch (SqlException e)
            {
                Console.Write("SqlException " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(" " + e.Message);
            }

            return null;
        }

        public List<int> GetListOfFriendsIdByContactId(int contactId)
        {
            try
            {
                SqlParameter _contactId = new SqlParameter("@contactId", contactId);
                var friends =  db.Database.SqlQuery<int>("SELECT * FROM List_GetListOfFriendsIdByContactId(@contactId)", _contactId).ToList();
                return (friends);
            }
            catch (SqlException e)
            {
                Console.Write("SqlException " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(" " + e.Message);
            }

            return null;
        }

        public List<Contact> GetListOfSomeonesByTitleAndContactId(string title, int contactId)
        {
            try
            {
                SqlParameter _title = new SqlParameter("@title", title);
                SqlParameter _contactId = new SqlParameter("@contactId", contactId);
                var someones =  db.Database.SqlQuery<Contact>("SELECT * FROM List_GetListOfSomeonesByTitleAndContactId(@title, @contactId)", _title, _contactId).ToList();
                return (someones);
            }
            catch (SqlException e)
            {
                Console.Write("SqlException " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(" " + e.Message);
            }

            return null;
        }

        public List<int> GetListOfSomeonesIdByTitleAndContactId(string title, int contactId)
        {
            try
            {
                SqlParameter _title = new SqlParameter("@title", title);
                SqlParameter _contactId = new SqlParameter("@contactId", contactId);
                var someones =  db.Database.SqlQuery<int>("SELECT * FROM List_GetListOfSomeonesIdByTitleAndContactId(@title, @contactId)", _title, _contactId).ToList();
                return (someones);
            }
            catch (SqlException e)
            {
                Console.Write("SqlException " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(" " + e.Message);
            }

            return null;
        }

        public void Update(List list)
        {
            db.Entry(list).State = System.Data.Entity.EntityState.Modified;
            //try
            //{
            //    SqlParameter listId = new SqlParameter("@listId", list.ListId);
            //    SqlParameter title = new SqlParameter("@title", list.Title);
            //    SqlParameter comment = new SqlParameter("@comment", list.Comment);
            //    SqlParameter creatorId = new SqlParameter("@creatorId", list.CreatorId);
            //    SqlParameter notRelevant = new SqlParameter("@notRelevant", list.NotRelevant);

            //    db.Database.SqlQuery<int>("List_UpdateList @listId, @title, @comment, @creatorId, @notRelevant",
            //                                              listId, title, comment, creatorId, notRelevant).FirstOrDefault();
            //}
            //catch (SqlException e)
            //{
            //    Console.Write("SqlException " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.Write(" " + e.Message);
            //}
        }

        public int? GetId(string title, int contactId)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetListOfContactsByContactId(int contactId)
        {
            throw new NotImplementedException();
        }

        public List<int> GetListOfContactsIdByContactId(int contactId)
        {
            throw new NotImplementedException();
        }
    }
}
