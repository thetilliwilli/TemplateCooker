﻿using System;
using TemplateCooker.Domain.Injections;

namespace TemplateCooker.Service.ResourceInjection.Injectors
{
    public class VariantResourceInjector : IResourceInjector
    {
        public Action<InjectionContext> Inject => context =>
        {
            switch (context.Injection)
            {
                case TableInjection _:
                    new TableResourceInjector().Inject(context);
                    break;
                case ImageInjection _:
                    new ImageResourceInjector().Inject(context);
                    break;
                case TextInjection _:
                    new TextResourceInjector().Inject(context);
                    break;
                case EmptyRowsInjection _:
                    new EmptyRowsInjector().Inject(context);
                    break;
                case NoopInjection _:
                    new NoopInjector().Inject(context);
                    break;
                case ExtendFormulasDownInjection _:
                    new ExtendFormulasDownInjector().Inject(context);
                    break;
                default:
                    throw new Exception($"Неизвестный тип объекта экспорта: {context.Injection?.GetType().Name}");
            }
        };
    }
}