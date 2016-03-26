﻿ 



//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template and will be re-created if deleted
//	   with default implementation.
// </auto-generated>
//------------------------------------------------------------------------------
using MyProject.Interface.Infrastructure;
using System.Data.Entity;
namespace MyProject.DB.Infrastructure
{

    /// <summary>
    /// MyProject implementation of Unit of Work
    /// </summary>
	public sealed partial class MyProjectUnitOfWork
		: UnitOfWork<DbContext>, IMyProjectUnitOfWork
	{
					
		/// <summary>
		/// BookRepository holder
		/// </summary>
        private MyProject.DB.Repository.BookRepository _bookRepository;

        /// <summary>
        /// Gets the BookRepository repository.
        /// </summary>
        /// <value>
        /// The BookRepository repository.
        /// </value>
        MyProject.Interface.Repository.IBookRepository IMyProjectUnitOfWork.BookRepository 
        { 
	        get
	        {
			        return _bookRepository = 
			        _bookRepository ?? new MyProject.DB.Repository.BookRepository(Context);
	        }
        }
			}

}