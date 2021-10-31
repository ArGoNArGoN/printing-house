using employee_manager_desktop.Architecture;
using employee_manager_desktop.MVVM.Models;
using employee_manager_desktop.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace employee_manager_desktop.MVVM.ViewModels
{
    public class NewOrdersViewModel
        : BaseViewModel
    {
        private IOrderStore store = null;
        private object currentView;

        public OrderModel SelectedOrder { get; set; }
        public ObservableCollection<OrderModel> OrderModels { get; set; }

        public Object CurrentView 
        {
            get => currentView;
            private set
            {
                currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public Command OpenOrderCommand { get; set; }

        public NewOrdersViewModel()
            : base()
        {
            OrderModels = new ObservableCollection<OrderModel>(new List<OrderModel>()
            {
                new OrderModel()
                {
                    Products = new List<Product>()
                    {
                        new Product()
                        { 
                            Title="К Нига",
                            Details=new List<DetailProductModel>()
                            {
                                new DetailProductModel()
                                {
                                    DetailProduct="Размеры книги",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Ширина", Value="22 см." },
                                        new Property() { Title="Длина", Value="31,5 см." },
                                    },
                                },
                                new DetailProductModel()
                                {
                                    DetailProduct="Размер текста",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Высота большой буквы в основном тексте", Value="20" },
                                        new Property() { Title="Высота маленькой буквы в основном тексте", Value="16" },
                                        new Property() { Title="Высота букв в сноске", Value="12" },
                                        new Property() { Title="Отступы от края", Value="10 20 8 20" },
                                        new Property() { Title="Заголовок", Value="Большими буквами" },
                                    },
                                },
                            },
                        },
                        new Product()
                        {
                            Title="К Нига",
                            Details=new List<DetailProductModel>()
                            {
                                new DetailProductModel()
                                {
                                    DetailProduct="Размеры книги",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Ширина", Value="22 см." },
                                        new Property() { Title="Длина", Value="31,5 см." },
                                    },
                                },
                                new DetailProductModel()
                                {
                                    DetailProduct="Размер текста",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Высота большой буквы в основном тексте", Value="20" },
                                        new Property() { Title="Высота маленькой буквы в основном тексте", Value="16" },
                                        new Property() { Title="Высота букв в сноске", Value="12" },
                                        new Property() { Title="Отступы от края", Value="10 20 8 20" },
                                        new Property() { Title="Заголовок", Value="Большими буквами" },
                                    },
                                },
                            },
                        },
                        new Product()
                        {
                            Title="К Нига",
                            Details=new List<DetailProductModel>()
                            {
                                new DetailProductModel()
                                {
                                    DetailProduct="Размеры книги",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Ширина", Value="22 см." },
                                        new Property() { Title="Длина", Value="31,5 см." },
                                    },
                                },
                                new DetailProductModel()
                                {
                                    DetailProduct="Размер текста",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Высота большой буквы в основном тексте", Value="20" },
                                        new Property() { Title="Высота маленькой буквы в основном тексте", Value="16" },
                                        new Property() { Title="Высота букв в сноске", Value="12" },
                                        new Property() { Title="Отступы от края", Value="10 20 8 20" },
                                        new Property() { Title="Заголовок", Value="Большими буквами" },
                                    },
                                },
                            },
                        },

                        new Product()
                        {
                            Title="К Нига",
                            Details=new List<DetailProductModel>()
                            {
                                new DetailProductModel()
                                {
                                    DetailProduct="Размеры книги",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Ширина", Value="22 см." },
                                        new Property() { Title="Длина", Value="31,5 см." },
                                    },
                                },
                                new DetailProductModel()
                                {
                                    DetailProduct="Размер текста",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Высота большой буквы в основном тексте", Value="20" },
                                        new Property() { Title="Высота маленькой буквы в основном тексте", Value="16" },
                                        new Property() { Title="Высота букв в сноске", Value="12" },
                                        new Property() { Title="Отступы от края", Value="10 20 8 20" },
                                        new Property() { Title="Заголовок", Value="Большими буквами" },
                                    },
                                },
                            },
                        },
                        new Product()
                        {
                            Title="К Нига",
                            Details=new List<DetailProductModel>()
                            {
                                new DetailProductModel()
                                {
                                    DetailProduct="Размеры книги",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Ширина", Value="22 см." },
                                        new Property() { Title="Длина", Value="31,5 см." },
                                    },
                                },
                                new DetailProductModel()
                                {
                                    DetailProduct="Размер текста",
                                    Properties = new List<Property>()
                                    {
                                        new Property() { Title="Высота большой буквы в основном тексте", Value="20" },
                                        new Property() { Title="Высота маленькой буквы в основном тексте", Value="16" },
                                        new Property() { Title="Высота букв в сноске", Value="12" },
                                        new Property() { Title="Отступы от края", Value="10 20 8 20" },
                                        new Property() { Title="Заголовок", Value="Большими буквами" },
                                    },
                                },
                            },
                        },
                    },
                    Description = "Что-то",
                }
            });
        }

        protected override void InitializeCommand()
        {
            base.InitializeCommand();

            OpenOrderCommand = new Command(OpenOrder);
        }

        public void OpenOrder(Object ob)
        {
            if (ob is not OrderModel)
                throw new ArgumentException("ob is not OrderModel");

            CurrentView = new OrderViewModel((OrderModel)ob, new Command((_) => CurrentView = null));
        }
    }
}
