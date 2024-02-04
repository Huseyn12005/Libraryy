using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Repositories.Concret;
using Library_Models.Entities.Concret;


Console.WriteLine("Hello, World!");

//LibraryContext context = new LibraryContext();


//AuthorRepository authorRepository = new AuthorRepository();
//var aut = authorRepository.GetById(5);


GenericRepository<Author> repository = new GenericRepository<Author>();
repository.GetAll();

BookRepository bookRepository = new BookRepository();

bookRepository.GetAllWithCaregory();
