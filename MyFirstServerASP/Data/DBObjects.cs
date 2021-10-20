using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Position.Any())
            {
                content.Position.AddRange(Positions.Select(c => c.Value));
            }

            if (!content.Worker.Any())
            {
                content.AddRange(
                    new Worker { firstName = "Максим", lastName = "Сащеко", position = Positions["Кассир"] },
                    new Worker { firstName = "Денис", lastName = "Скурат", position = Positions["Директор"] }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Position> position;

        public static Dictionary<string, Position>  Positions
        {
            get
            {
                if(position == null)
                {
                    var list = new Position[]
                    {
                        new Position {positionName="Директор"},
                        new Position {positionName="Кассир"}
                    };

                    position = new Dictionary<string, Position>();
                    foreach (Position el in list)
                    {
                        position.Add(el.positionName, el);
                    }
                }

                return position;
            }
        }
    }
}
