using SpecialistCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpecialistCatalog.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №1", Description="Управление проектом. История. Определения. Типы.", Link = @"https://drive.google.com/file/d/1Map-wtpPi8-R9qel3fYzNoot7BTRS8He/view?usp=sharing" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №2", Description="Жизненный цикл ИТ проекта. Организационная структура", Link=@"https://drive.google.com/file/d/1Uv3zUFopfRlmwpx3zj7hka1q-9EyeKRb/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №3", Description="План управления проектом. \nОрганизационная структура проекта\nПостроение ИСР", Link = @"https://drive.google.com/file/d/1PAkn6nY_3aKOpaTMT9Gc-RpeGyVlufr9/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №4", Description="Процессы управления проектом.", Link = @"https://drive.google.com/file/d/1n5HRPNbHgqw7wZmSfM8QDLFip8VKUzF7/view?usp=sharing" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №5", Description="Контроль и аудит проекта", Link = @"https://drive.google.com/file/d/1zvOoTChVwVTWu8RIAm-X9n3t06HDaPIj/view?usp=sharing" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №6", Description="Планирование рисков проекта", Link = @"https://drive.google.com/file/d/1xN1ZMddTcdT2CCzMPIFFHKnWrr5nQNyB/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №7", Description="Контроль и реализация проекта." , Link = @"https://drive.google.com/file/d/10h51YMzTaRooQ8aaQFRoCwlhCuMBg2Ii/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №8-1", Description="Управление коммуникациями проекта" , Link = @"https://drive.google.com/file/d/133wVrqo4MXEMYZHmVmZVSfCg1iNFUL8O/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №8-2", Description="Планирование коммуникаций и управление конфигурацией в проекте." , Link = @"https://drive.google.com/file/d/1rgwp3ttDLLbxpEDhAKV_P1kBG10TfNmc/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №9", Description="Оценка реализуемости проекта" , Link = @"https://drive.google.com/file/d/1uZ3JBqJXV5-hlpjGK7fBeqwswE8Ywlof/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №10", Description="Идентификация рисков проекта" , Link = @"https://drive.google.com/file/d/1cIZfShMHmvIc8tl75PrvB_aq5A8v_YJC/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №11", Description="Управление проектом на базе проектирования.", Link = @"https://drive.google.com/file/d/1yGvYgLI1mg3YH0tg-vh3KI1oU1oWUwud/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №12", Description="Реализация плана коммуникаций." , Link = @"https://drive.google.com/file/d/1l1gYPSo-aD99oKqDGvsChx9O-NhBp9Ul/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Лекция УП №13", Description="Управление проектом на фазе разработки и внедрения." , Link = @"https://drive.google.com/file/d/1fbBlh1pmPGnypWUt83fIGhnT50-E9g0_/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Дополнительные материалы №1", Description="Планирование проекта" , Link = @"https://drive.google.com/file/d/1Y6G3VnJIXVgrZlSYqQYJmsV32uxHdAPr/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Дополнительные материалы №2", Description="Сетевой анализ и календарное планирование" , Link = @"https://drive.google.com/file/d/1jJ8Lwh7K0-jwOe73GP_ul4s4AFjZFNqt/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Дополнительные материалы №3", Description="PMI - Руководство к своду знаний об управлении проектом" , Link = @"https://drive.google.com/file/d/1QiyD0YLduwqsNZxMAoSZaNqQZj3w6c1_/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Вопросы к зачёту/экзамену", Description="Перечень вопросов к зачёту/экзамену по дисциплине 'Управление Проектами'" , Link = @"https://drive.google.com/file/d/1Odo03wSrSr3icscsjMhcPH7dWTYXjSdu/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Интелектуальная карта", Description="Пример интелектуальной карты для облегчения процесса запоминания" , Link = @"https://coggle.it/diagram/YA6CR6dEAQDqoVmq/t/управление-проектами"},
                
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}