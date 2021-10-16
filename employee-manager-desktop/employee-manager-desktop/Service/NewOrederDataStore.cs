using ClientRemouting;
using Contract.Interface;
using Contract.Model;
using employee_manager_desktop.Data;
using employee_manager_desktop.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace employee_manager_desktop.Service
{
    public class NewOrederDataStore
        : INewOrederDataStore
    {
        // protected OrderOperation orderOperation;

        public NewOrederDataStore()
        {
            // orderOperation = new OrderOperation();
        }

        public List<NewOrder> GetNewOrders()
        {
            /*
            var list = orderOperation.GetNewOrders();

            return list.Select(x => new NewOrder()
            {
                Client = x.Client,
                ClientManager = x.ClientManager,
                ProductInOrders = x.ProductInOrders,
                DateCreate = x.DateCreate,
                Description = x.Description,
            }).ToList();*/

            return new List<NewOrder>()
            {
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },
                new NewOrder()
                {
                    Client = new Client()
                    {
                        FirsName = "Ваяся",
                        LastName = "Пупкин",
                        Company = "None",
                    },
                    ClientManager = new ClientManager()
                    {
                        FirsName = "Буба",
                        LastName = "Пупа",
                    },
                    DateCreate = DateTime.Now,
                    Description = "Что-то",
                    ProductInOrders = new List<IProductInOrder<IProduct>>()
                    {
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Ручка",
                            },
                        },
                        new ProductInOrder<IProduct>()
                        {
                            Product = new Product()
                            {
                                Name = "Лист А4",
                            },
                        }
                    }
                },

            };
        }
    }
}
