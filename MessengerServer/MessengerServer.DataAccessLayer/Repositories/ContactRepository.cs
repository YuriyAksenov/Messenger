﻿using MessengerServer.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MessengerServer.DataAccessLayer.EntityFramework;

namespace MessengerServer.DataAccessLayer.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private MessengerContext db;

        public ContactRepository(MessengerContext context)
        {
            this.db = context;
        }

        public void Create(Contact item)
        {
            db.Contacts.Add(item);
            /*try
            {
                SqlParameter firstName = new SqlParameter("@firstName", item.FirstName);
                SqlParameter secondName = new SqlParameter("@secondName", item.SecondName);
                SqlParameter middleName = new SqlParameter("@middleName", item.MiddleName);
                SqlParameter sex = new SqlParameter("@sex", item.Sex);
                SqlParameter birthDate = new SqlParameter("@birthDate", item.BirthDate);
                SqlParameter email = new SqlParameter("@email", item.Email);
                SqlParameter phone  = new SqlParameter("@phone", item.Phone);
                SqlParameter comment = new SqlParameter("@comment", item.Comment);
                SqlParameter creationDate = new SqlParameter("@creationDate", item.CreationDate);
                SqlParameter modificationDate = new SqlParameter("@modificationDate", item.ModificationDate);
                SqlParameter disable = new SqlParameter("@disable", item.Disable);
                SqlParameter notRelevant = new SqlParameter("@notRelevant", item.NotRelevant);

                db.Database.SqlQuery<int>("Contact_InsertContact @firstName, @secondName, @middleName, @sex, @birthDate, @email, @phone, @comment, @creationDate, @modificationDate, @disable, @notRelevant",
                                                                                  firstName, secondName, middleName, sex, birthDate, email, phone, comment, creationDate, modificationDate, disable, notRelevant).FirstOrDefault();
            }
            catch (SqlException e)
            {
                Console.Write("SqlException " + e.Message);
            }
            catch (Exception e)
            {
                Console.Write(" " + e.Message);
            }*/
        }

        public void Delete(int id)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact != null)
                db.Contacts.Remove(contact);
        }

        public IEnumerable<Contact> Find(Func<Contact, bool> predicate)
        {
            return db.Contacts.Where(predicate).ToList();
        }

        public Contact Get(int id)
        {
            return db.Contacts.Find(id);
            //try
            //{
            //    SqlParameter contactId = new SqlParameter("@contactId", id);
            //    var contact =  db.Database.SqlQuery<Contact>("SELECT * FROM Contact_GetContactByContactId(@contactId)", contactId).FirstOrDefault();
            //    return (contact);
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

        public Contact GetByEmail(string email)
        {
            throw new NotImplementedException();
            //try
            //{
            //    SqlParameter _email = new SqlParameter("@email", email);
            //    var contact =  db.Database.SqlQuery<Contact>("SELECT * from Contact_GetContactByEmail(@email)", _email).FirstOrDefault();
            //    return (contact);
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

        public IEnumerable<Contact> GetAll()
        {
            return db.Contacts;
        }

        public Contact GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public int? GetContactIdByEmail(string email)
        {
            try
            {
                SqlParameter _email = new SqlParameter("@email", email);
                var contactId = db.Database.SqlQuery<int>("SELECT [dbo].[Contact_GetContactIdByEmail](@email)",_email).FirstOrDefault();
                return (contactId);
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

        public int? GetIdByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public int? GetIdByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            db.Entry(contact).State = EntityState.Modified;
            //try
            //{
            //    SqlParameter contactId = new SqlParameter("@contactId", item.ContactId);
            //    SqlParameter firstName = new SqlParameter("@firstName", item.FirstName);
            //    SqlParameter secondName = new SqlParameter("@secondName", item.SecondName);
            //    SqlParameter middleName = new SqlParameter("@middleName", item.MiddleName);
            //    SqlParameter sex = new SqlParameter("@sex", item.Sex);
            //    SqlParameter birthDate = new SqlParameter("@birthDate", item.BirthDate);
            //    SqlParameter email = new SqlParameter("@email", item.Email);
            //    SqlParameter phone  = new SqlParameter("@phone", item.Phone);
            //    SqlParameter comment = new SqlParameter("@comment", item.Comment);
            //    SqlParameter creationDate = new SqlParameter("@creationDate", item.CreationDate);
            //    SqlParameter modificationDate = new SqlParameter("@modificationDate", item.ModificationDate);
            //    SqlParameter disable = new SqlParameter("@disable", item.Disable);
            //    SqlParameter notRelevant = new SqlParameter("@notRelevant", item.NotRelevant);

            //    db.Database.SqlQuery<int>("Contact_UpdateContact @contactId @firstName, @secondName, @middleName, @sex, @birthDate, @email, @phone, @comment, @creationDate, @modificationDate, @disable, @notRelevant",
            //                                                     contactId, firstName, secondName, middleName, sex, birthDate, email, phone, comment, creationDate, modificationDate, disable, notRelevant).FirstOrDefault();
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
    }
}
