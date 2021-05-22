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
                //Лекции по УП, материалы
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №1", Description="Управление проектом. История. Определения. Типы.", Link = @"https://drive.google.com/file/d/1Map-wtpPi8-R9qel3fYzNoot7BTRS8He/view?usp=sharing" },
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №2", Description="Жизненный цикл ИТ проекта. Организационная структура", Link=@"https://drive.google.com/file/d/1Uv3zUFopfRlmwpx3zj7hka1q-9EyeKRb/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №3", Description="План управления проектом. \nОрганизационная структура проекта\nПостроение ИСР", Link = @"https://drive.google.com/file/d/1PAkn6nY_3aKOpaTMT9Gc-RpeGyVlufr9/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №4", Description="Процессы управления проектом.", Link = @"https://drive.google.com/file/d/1n5HRPNbHgqw7wZmSfM8QDLFip8VKUzF7/view?usp=sharing" },
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №5", Description="Контроль и аудит проекта", Link = @"https://drive.google.com/file/d/1zvOoTChVwVTWu8RIAm-X9n3t06HDaPIj/view?usp=sharing" },
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №6", Description="Планирование рисков проекта", Link = @"https://drive.google.com/file/d/1xN1ZMddTcdT2CCzMPIFFHKnWrr5nQNyB/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №7", Description="Контроль и реализация проекта." , Link = @"https://drive.google.com/file/d/10h51YMzTaRooQ8aaQFRoCwlhCuMBg2Ii/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №8-1", Description="Управление коммуникациями проекта" , Link = @"https://drive.google.com/file/d/133wVrqo4MXEMYZHmVmZVSfCg1iNFUL8O/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №8-2", Description="Планирование коммуникаций и управление конфигурацией в проекте." , Link = @"https://drive.google.com/file/d/1rgwp3ttDLLbxpEDhAKV_P1kBG10TfNmc/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №9", Description="Оценка реализуемости проекта" , Link = @"https://drive.google.com/file/d/1uZ3JBqJXV5-hlpjGK7fBeqwswE8Ywlof/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №10", Description="Идентификация рисков проекта" , Link = @"https://drive.google.com/file/d/1cIZfShMHmvIc8tl75PrvB_aq5A8v_YJC/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №11", Description="Управление проектом на базе проектирования.", Link = @"https://drive.google.com/file/d/1yGvYgLI1mg3YH0tg-vh3KI1oU1oWUwud/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №12", Description="Реализация плана коммуникаций." , Link = @"https://drive.google.com/file/d/1l1gYPSo-aD99oKqDGvsChx9O-NhBp9Ul/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Лекция УП №13", Description="Управление проектом на фазе разработки и внедрения." , Link = @"https://drive.google.com/file/d/1fbBlh1pmPGnypWUt83fIGhnT50-E9g0_/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Дополнительные материалы №1", Description="Планирование проекта" , Link = @"https://drive.google.com/file/d/1Y6G3VnJIXVgrZlSYqQYJmsV32uxHdAPr/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Дополнительные материалы №2", Description="Сетевой анализ и календарное планирование" , Link = @"https://drive.google.com/file/d/1jJ8Lwh7K0-jwOe73GP_ul4s4AFjZFNqt/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Дополнительные материалы №3", Description="PMI - Руководство к своду знаний об управлении проектом" , Link = @"https://drive.google.com/file/d/1QiyD0YLduwqsNZxMAoSZaNqQZj3w6c1_/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Вопросы к зачёту/экзамену", Description="Перечень вопросов к зачёту/экзамену по дисциплине 'Управление Проектами'" , Link = @"https://drive.google.com/file/d/1Odo03wSrSr3icscsjMhcPH7dWTYXjSdu/view?usp=sharing"},
                new Item { Id = Guid.NewGuid().ToString(), Is_UPLection = true, Text = "Интелектуальная карта", Description="Пример интелектуальной карты для облегчения процесса запоминания" , Link = @"https://coggle.it/diagram/YA6CR6dEAQDqoVmq/t/управление-проектами"},
                //АИС на ЖД, лекции
                new Item {Id = Guid.NewGuid().ToString(), Is_AISnaGT = true, Text = "АИС ЭДВ", Description = "Автоматизированная информационная система организации перевозок грузов по безбумажной технологии на основе электронной накладной ", Link = @"https://drive.google.com/file/d/1Hj4uwL7P9oY3D0M8zt6trOk2olIbwpPI/view?usp=sharing"},
                new Item {Id = Guid.NewGuid().ToString(), Is_AISnaGT = true, Text = "АКС ФТО", Description = "Автоматизированная комплексная система фирменного транспортного обслуживания", Link = @"https://drive.google.com/file/d/104Qs9s29BR6gdL1uLOlQ0DHKA5WShe5Z/view?usp=sharing"},
                new Item {Id = Guid.NewGuid().ToString(), Is_AISnaGT = true, Text = "АСУСС", Description = "Поступление и обработка оперативных сообщений", Link = @"https://drive.google.com/file/d/1tiifnukkDywYCT2VTEggwmCieaONK_9X/view?usp=sharing"},
                new Item {Id = Guid.NewGuid().ToString(), Is_AISnaGT = true, Text = "БКО Экспресс", Description = "Принципы работы", Link = @"https://drive.google.com/file/d/12iYhBiqLMlEs1SbGbz_OlN_9YjFIZRKs/view?usp=sharing"},
                //ИТПРИС, лекции
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLection = true, Text = "Эффективное программирование в Windows PowerShell", Description = "Лекция по ИТПРИС", Link = @"https://drive.google.com/file/d/1IfYgfe--yr14jZV31O17WVQHFOdYGlRd/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLection = true, Text = "Основы платформы Microsoft .NET", Description = "Лекция по ИТПРИС", Link = @"https://drive.google.com/file/d/1upoaVox2VShKNs5cynRXY7A4-9t9uKWn/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLection = true, Text = "Права доступа к файлам и к папкам в Windows", Description = "Лекция по ИТПРИС", Link = @"https://drive.google.com/file/d/11BbBMZJuQjIb-1dMCpRt7GccLEcgCsfo/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLection = true, Text = "Что такое .NET?", Description = "Лекция по ИТПРИС", Link = @"https://drive.google.com/file/d/1GL4PAzbB9vh3ijekmbwNu6sMollZphq9/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLection = true, Text = "Введение в технологии языка сценариев", Description = "Лекция для пользователей без базовых знаний", Link = @"https://drive.google.com/file/d/1oJyn2ZAV-otM7f_3xCNv9wsaZCWcV_Vl/view?usp=sharing" },
                //ИТПРИС, Лабораторные работы
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №1", Description = "Установка операционных систем на виртуальную машину", Link = @"https://drive.google.com/file/d/1db0O4m8GSrgGSBvYwB_p5ARxxm1C4een/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №2", Description = "Работа файловой системой Linux", Link = @"https://drive.google.com/file/d/1VqBZlpb8CO_fJmGQCloUp_eEUt096YW4/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №3", Description = "Изучить команды для работы с файловой системой Linux", Link = @"https://drive.google.com/file/d/1MjDffsQrMJ5FdiEJ7mCLNb_9A7Bprjwl/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №4", Description = "Управление пользователями и группами в ОС Unix/Linux", Link = @"https://drive.google.com/file/d/1nEuc2a5F9iCIWnbFy_VTIjOI7fKW6ulF/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №5", Description = "Работа с сервером баз данных MySQL", Link = @"https://drive.google.com/file/d/1OxpScqfnaY8q_Tr67tt4AVbxV1fSRWDe/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №6", Description = "Настройка аутентификаций и привелегий", Link = @"https://drive.google.com/file/d/1Z4-Rsk7GWHUBM0aR1AgrvjlfYt0yd7El/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №7", Description = "Работа с графической утилитой MySQL Workbench", Link = @"https://drive.google.com/file/d/1whk6VCx3UV-lmcOmOrOq1VPNalmtK7ja/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №8", Description = "Настройка системы разрешений файлов NTFS", Link = @"https://drive.google.com/file/d/1l2q1mT7rxd73sL6S6uHFV-5ltgTFlQw6/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №9", Description = "Управление учетными записями в ОС Windows", Link = @"https://drive.google.com/file/d/1vkpu0YNm3oPGkYNIVbJuOe29tQNdfj1L/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №10", Description = "Интерфейс командной строки.NET Core (CLI)", Link = @"https://drive.google.com/file/d/12WevbZ4I0w6Z4LXPcBBPO1zJqfu1YusZ/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №11", Description = "Создание кроссплатформенного приложения ASP.NET Core", Link = @"https://drive.google.com/file/d/13SRdLCIYMCS-_gTGRDU2IzitjumghpL3/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №12", Description = "Работа с редактором Visual Studio Code", Link = @"https://drive.google.com/file/d/1unHK3uEL9sL3hrm17Srmni3gD8lSvrjH/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №13-1", Description = "Работа с PowerShell в Visual Studio Code", Link = @"https://drive.google.com/file/d/1lhn3re-YFl_Tud25miOQGEiUoTuaA5Ws/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_ITPRISLabs = true, Text = "Лабораторная работа по ИТПРИС №13-2", Description = "Работа с PowerShell в Visual Studio Code", Link = @"https://drive.google.com/file/d/1S7Lemtshc358TBPRHqBkbQ-0sXQwbiGo/view?usp=sharing" },
                // СИИ, Лекции
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILection = true, Text = "Исскусственный интелект. \nАлгоритм имитации отжига", Description = "Лекция по СИИ", Link = @"https://drive.google.com/file/d/1wV1A2ApmnPHZyHXSR9WVnvWNg5ax5-jY/view?usp=sharing"},
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILection = true, Text = "Введение в экспертные системы", Description = "Основные понятия и определения", Link = @"https://drive.google.com/file/d/1JyFNEYpX5VN84fswlmU8f_xWACZi917C/view?usp=sharing"},
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILection = true, Text = "Нейронные сети Хэмминга", Description = "Лекция по СИИ", Link = @"https://neuronus.com/theory/nn/965-nejronnye-seti-khemminga.html"},
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILection = true, Text = "Модели Нейронов", Description = "Лекция по СИИ", Link = @"https://intuit.ru/studies/courses/61/61/lecture/20436"},
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILection = true, Text = "Обучение сети с учителем и без него", Description = "Лекция по СИИ", Link = @"https://neurohive.io/ru/osnovy-data-science/obuchenie-s-uchitelem-bez-uchitelja-s-podkrepleniem/"},
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILection = true, Text = "Введение в компьютерные сети", Description = "Лекция по СИИ", Link = @"https://www.osp.ru/os/1997/04/179189"},
                // СИИ, Лабораторные работы
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Отчёт о XOR", Description = "Объяснение проблемы XOR, для первой лабораторной работы", Link = @"https://drive.google.com/file/d/1e7Bx_kxzjgtmT7Q_xJE2RmU-m9S0Z8pJ/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Лабораторная работа по СИИ №1", Description = "Реализация булевых функций однослойным персептроном", Link = @"https://drive.google.com/file/d/10t3oIb5aDJrtjCwZNRFl4u0LSOA3ClmZ/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Лабораторная работа по СИИ №2", Description = "Применение алгоритма обратного распространения в компьютерных играх", Link = @"https://drive.google.com/file/d/1UJG845L-RUMHA6Bfz_GEyWXRCKEULSHQ/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Лабораторная работа по СИИ №3", Description = "Пример решения задачи персонализации с помощью алгоритма адаптивного резонанса.", Link = @"https://drive.google.com/file/d/1E_z0P-xdvcBk0uduhy0bLY1KZJNsiOqi/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Лабораторная работа по СИИ №4", Description = "Применение искусственного интелекта для решения задач генетического наследования", Link = @"https://drive.google.com/file/d/1T9Pe8zXvF1atSuBxH0Bq4BjGKbegCKwq/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Лабораторная работа по СИИ №5", Description = "Применение экспертных систем", Link = @"https://drive.google.com/file/d/1oxoAW-HPz8-d6jhGD7HqicOAFpUw4hN-/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Лабораторная работа по СИИ №6", Description = "Алгоритм муравья для решения задачи коммивояжёра", Link = @"https://drive.google.com/file/d/1Ia5_opUHbNNMRtPRJPrEGeexyJwDLS7F/view?usp=sharing" },
                new Item {Id = Guid.NewGuid().ToString(), Is_SIILabs = true, Text = "Лабораторная работа по СИИ №7", Description = "Язык программирования Python", Link = @"https://drive.google.com/file/d/17omlh1ipb_GB5qeiBT_tyklddzA4aH-f/view?usp=sharing" },
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