internal class Program
{
    private static void Main(string[] args)


    {
        int tel = 0, cab = 0, inte = 0, opci = 0, opci2 = 0, opci3 = 0;
        int tot = 0, insta = 0, equipo = 0, desc = 0, tot2 =0, precio = 0;
        string opcion = "", plan = "";

        
        do
        {


            Console.WriteLine("SERVICIO DE TELEFONÍA CABLE E INTERNET");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su Nombre:");
            String name = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido:");
            String apel = Console.ReadLine();
            Console.WriteLine("Ingrese su direccion");
            String direc = Console.ReadLine();
            Random r = new Random();
            

           
            Console.WriteLine("");
            Console.WriteLine("¿Qué desea realizar?");
            Console.WriteLine("1.Adquirir Plan");
            Console.WriteLine("2.Pagar mensualidad");
            opci = int.Parse(Console.ReadLine());
            Console.Clear();



            if (opci == 1)

            {
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("PLANES DISPONIBLES");
                Console.WriteLine("");
                Console.WriteLine("\t 1. TELEFONÍA");
                Console.WriteLine("Plan Bronce:     Q100.00");
                Console.WriteLine("Plan Oro:        Q200.00");
                Console.WriteLine("Plan Platinum:   Q300.00");
                Console.WriteLine("\t 2. CABLE");
                Console.WriteLine("Plan Bronce      Q150.00");
                Console.WriteLine("Plan Oro         Q250.00");
                Console.WriteLine("Plan Platinum    Q350.00");
                Console.WriteLine("\t 3. INTERNET");
                Console.WriteLine("Plan Bronce      Q200.00");
                Console.WriteLine("Plan Oro         Q300.00");
                Console.WriteLine("Plan Platinum    Q400.00");
                Console.WriteLine("");
                Console.WriteLine("Al adquirir un combo, recibirá un descuento especial");
                Console.WriteLine("COMBOS DISPONIBLES");
                Console.WriteLine("");
                Console.WriteLine("\t 4. COMBO 1: 2 PLANES BRONCE");
                Console.WriteLine("\t 5. COMBO 2: 2 PLANES ORO");
                Console.WriteLine("\t 6. COMBO 3: 2 PLANES PLATINUM");
                Console.WriteLine("\t 7. COMBO 4: 3 PLANES BRONCE");
                Console.WriteLine("\t 8. COMBO 5: 3 PLANES ORO");
                Console.WriteLine("\t 9. COMBO 6: 3 PLANES PLATINUM");
                Console.WriteLine("");
                Console.WriteLine("¿Que servicio desea adquirir?");
                opci2 = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opci2)
                {
                    case 1:
                        Console.ReadKey();
                        Console.WriteLine("¿Qué plan de TELEFONÍA desea activar?");
                        Console.WriteLine("\t 1. Plan Bronce:     Q100.00");
                        Console.WriteLine("\t 2. Plan Oro:        Q200.00");
                        Console.WriteLine("\t 3. Plan Platinum:   Q300.00");
                        opci3 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opci3)
                        {

                            case 1:
                                tel = (int)(100);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(tel + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "TELEFONÍA BRONCE";
                                precio = (int)(tel);
                                break;

                            case 2:
                                tel = (int)(200);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(tel + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "TELEFONÍA ORO";
                                precio = (int)(tel);
                                break;
                            case 3:
                                tel = (int)(300);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(tel + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "TELEFONÍA PLATINUM";
                                precio = (int)(tel);
                                break;
                            case 4:
                                Console.ReadKey();
                                Console.WriteLine("Ingrese una opción válida");

                                Console.Clear(); break;




                        }

                        break;


                    case 2:
                        Console.ReadKey();
                        Console.WriteLine("¿Qué plan de CABLE desea activar?");
                        Console.WriteLine("\t Plan Bronce   Q150.00");
                        Console.WriteLine("\t Plan Oro      Q250.00");
                        Console.WriteLine("\t Plan Platinum Q350.00");
                        opci3 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opci3)
                        {

                            case 1:
                                cab = (int)(150);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(cab + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "CABLE BRONCE";
                                precio = (int)(cab);
                                break;

                            case 2:
                                cab = (int)(250);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(cab + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "CABLE ORO";
                                precio = (int)(cab);
                                break;
                            case 3:
                                cab = (int)(350);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(cab + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "CABLE PLATINUM";
                                precio = (int)(cab);

                                break;
                            case 4:

                                Console.WriteLine("Ingrese una opción válida");
                                Console.Clear();
                                break;

                        }

                        break;


                    case 3:

                        Console.ReadKey();
                        Console.WriteLine("¿Qué plan de INTERNET desea activar?");
                        Console.WriteLine("\t Plan Bronce   Q200.00");
                        Console.WriteLine("\t Plan Oro      Q300.00");
                        Console.WriteLine("\t Plan Platinum Q400.00");
                        opci3 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opci3)
                        {

                            case 1:
                                inte = (int)(200);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(inte + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "INTERNET BRONCE";
                                precio = (int)(inte);
                                break;



                            case 2:
                                inte = (int)(300);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(inte + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "INTERNET ORO";
                                precio = (int)(inte);
                                break;

                            case 3:
                                inte = (int)(400);
                                insta = (int)(100);
                                equipo = (int)(150);
                                desc = (int)(0);
                                tot = (int)(inte + insta + equipo);
                                tot2 = (int)(tot - desc);
                                plan = "INTERNET PLATINUM";
                                precio = (int)(inte);
                                break;
                            case 4:

                                Console.WriteLine("Elija un opcion valida");
                                Console.Clear();
                                break;
                        }

                        break;

                    case 4:
                        Console.ReadKey();
                        Console.WriteLine("COMBO 1: 2 Planes BRONCE");
                        Console.WriteLine("Eliga dos planes BRONCE");
                        Console.WriteLine("\t 1. TELEFONÍA Y CABLE");
                        Console.WriteLine("\t 2. TELEFONÍA E INTERNET");
                        Console.WriteLine("\t 3. CABLE E INTERNET");
                        opci3 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opci3)
                        {

                            case 1:
                                tel = (int)(100);
                                cab = (int)(150);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(tel + cab + insta + equipo);
                                desc = (int)(tot * 0.05);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO TELEFONÍA Y CABLE BRONCE";
                                precio = (int)(tel + cab);
                                break;

                            case 2:
                                tel = (int)(100);
                                inte = (int)(200);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(tel + inte + insta + equipo);
                                desc = (int)(tot * 0.05);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO TELEFONÍA E INTERNET BRONCE";
                                precio = (int)(tel + inte);
                                break;

                            case 3:
                                cab = (int)(150);
                                inte = (int)(200);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(inte + cab + insta + equipo);
                                desc = (int)(tot * 0.05);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO CABLE E INTERNET BRONCE";
                                precio = (int)(inte + cab);
                                break;
                            case 4:

                                Console.WriteLine("Ingrese una opcion valida");

                                break;
                        }

                        break;

                    case 5:
                        Console.ReadKey();
                        Console.WriteLine("COMBO 2: 2 Planes ORO");
                        Console.WriteLine("Eliga dos planes ORO");
                        Console.WriteLine("\t 1. TELEFONÍA Y CABLE");
                        Console.WriteLine("\t 2. TELEFONÍA E INTERNET");
                        Console.WriteLine("\t 3. CABLE E INTERNET");
                        opci3 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opci3)
                        {

                            case 1:
                                tel = (int)(200);
                                cab = (int)(250);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(tel + cab + insta + equipo);
                                desc = (int)(tot * 0.07);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO TELEFONÍA Y CABLE ORO";
                                break;
                                precio = (int)(tel + cab);

                            case 2:
                                tel = (int)(200);
                                inte = (int)(300);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(tel + inte + insta + equipo);
                                desc = (int)(tot * 0.07);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO TELEFONÍA E INTERNET ORO";
                                precio = (int)(inte + tel);
                                break;

                            case 3:
                                cab = (int)(250);
                                inte = (int)(300);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(inte + cab + insta + equipo);
                                desc = (int)(tot * 0.07);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO CABLE E INTERNET";
                                precio = (int)(inte + cab);
                                break;
                            case 4:

                                Console.WriteLine("Ingrese una opcion valida");

                                break;
                        }
                        break;
                    case 6:
                        Console.ReadKey();
                        Console.WriteLine("COMBO 3: 2 Planes PLATINUM");
                        Console.WriteLine("Eliga dos planes PLATINUM");
                        Console.WriteLine("\t 1. TELEFONÍA Y CABLE");
                        Console.WriteLine("\t 2. TELEFONÍA E INTERNET");
                        Console.WriteLine("\t 3. CABLE E INTERNET");
                        opci3 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opci3)
                        {

                            case 1:
                                tel = (int)(300);
                                cab = (int)(350);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(tel + cab + insta + equipo);
                                desc = (int)(tot * 0.10);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO TELEFONÍA Y CABLE PLATINUM";
                                precio = (int)(tel + cab);
                                break;

                            case 2:
                                tel = (int)(300);
                                inte = (int)(400);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(tel + inte + insta + equipo);
                                desc = (int)(tot * 0.10);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO TELEFONÍA E INTERNET PLATINUM";
                                precio = (int)(inte + tel);
                                break;

                            case 3:
                                cab = (int)(350);
                                inte = (int)(400);
                                insta = (int)(100);
                                equipo = (int)(150);
                                tot = (int)(cab + inte + insta + equipo);
                                desc = (int)(tot * 0.10);
                                tot2 = (int)(tot - desc);
                                plan = "COMBO CABLE E INTERNET PLATINUM";
                                precio = (int)(inte + cab);
                                break;
                            case 4:

                                Console.WriteLine("Ingrese una opcion valida");

                                break;
                        }
                        break;

                    case 7:



                        tel = (int)(100);
                        cab = (int)(150);
                        inte = (int)(200);
                        equipo = (int)(150);
                        insta = (int)(100);
                        tot = (int)(tel + cab + inte + insta + equipo);
                        desc = (int)(tot * 0.06);
                        tot2 = (int)(tot - desc);
                        plan = "COMBO TELEFONÍA, CABLE E INTERNET BRONCE";
                        precio = (int)(tel + cab + inte);
                        break;

                    case 8:

                        tel = (int)(200);
                        cab = (int)(250);
                        inte = (int)(300);
                        equipo = (int)(150);
                        insta = (int)(100);
                        tot = (int)(tel + cab + inte + insta + equipo);
                        desc = (int)(tot * 0.08);
                        tot2 = (int)(tot - desc);
                        plan = "COMBO TELEFONÍA, CABLE E INTERNET ORO";
                        precio = (int)(tel + cab + inte);
                        break;

                    case 9:

                        tel = (int)(100);
                        cab = (int)(150);
                        inte = (int)(200);
                        equipo = (int)(150);
                        insta = (int)(100);
                        tot = (int)(tel + cab + inte + insta + equipo);
                        desc = (int)(tot * 0.12);
                        tot2 = (int)(tot - desc);
                        plan = "COMBO TELEFONÍA, CABLE E INTERNET PLATINUM";
                        precio = (int)(tel + cab + inte);
                        break;

                    case 10:

                        Console.WriteLine("Ingrese una opcion valida");


                        break;
                }
               
                    Console.ReadKey();
                    Console.WriteLine("SERVICIOS DE TELEFONÍA, CABLE E INTERNET");
                    Console.WriteLine("           CUILAPA SANTA ROSA");
                    Console.WriteLine("");
                    Console.WriteLine("CONTRATACIÓN DE PLAN");
                    Console.WriteLine("");
                    Console.WriteLine("FACTURA NO:" + r.Next(1, 100));
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("NOMBRE:  \t" + name);
                    Console.WriteLine("");
                    Console.WriteLine("APELLIDO:\t" + apel);
                    Console.WriteLine("");
                    Console.WriteLine("DIRECCIÓN:\t" + direc);
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("PLAN ADQUIRIDO:\t" + plan);
                    Console.WriteLine("");
                    Console.WriteLine("PRECIO DEL PLAN \t" + " Q" + precio);
                    Console.WriteLine("");
                    Console.WriteLine("NOTA: Se le cobrará Q150 de equipo y Q100 de gastos de instalación");
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("SUBTOTAL:  \t\t" + " Q" + tot);
                    Console.WriteLine("DESCUENTO AGREGADO:\t" + "-Q " + desc);
                    Console.WriteLine("\t                 ______");
                    Console.WriteLine("TOTAL A PAGAR  \t\t" + " Q" + tot2);
                    Console.WriteLine("______________________________________________________________________");
                }
            

            else if (opci == 2)
            {
                Console.WriteLine("Ingrese el mes que desea cancelar");
                String mes = Console.ReadLine();


                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("PLANES DISPONIBLES");
                Console.WriteLine("");
                Console.WriteLine("\t 1. TELEFONÍA");
                Console.WriteLine("\t 2. CABLE");
                Console.WriteLine("\t 3. INTERNET");
                Console.WriteLine("COMBOS");
                Console.WriteLine("\t 4. COMBO 1: 2 PLANES BRONCE");
                Console.WriteLine("\t 5. COMBO 2: 2 PLANES ORO");
                Console.WriteLine("\t 6. COMBO 3: 2 PLANES PLATINUM");
                Console.WriteLine("\t 7. COMBO 4: 3 PLANES BRONCE");
                Console.WriteLine("\t 8. COMBO 5: 3 PLANES ORO");
                Console.WriteLine("\t 9. COMBO 6: 3 PLANES PLATINUM");
                Console.WriteLine("");
                Console.WriteLine("¿QUE PLAN DESEA RENOVAR?");
                opci2 = int.Parse(Console.ReadLine());
                Console.Clear();

                
                    switch (opci2)
                    {
                        case 1:
                            Console.ReadKey();
                            Console.WriteLine("¿Qué plan de TELEFONÍA tiene activo?");
                            Console.WriteLine("\t 1. Plan Bronce");
                            Console.WriteLine("\t 2. Plan Oro");
                            Console.WriteLine("\t 3. Plan Platinum");
                            opci3 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opci3)
                            {

                                case 1:
                                    tel = (int)(100);
                                    tot = (int)(tel);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "TELEFONÍA BRONCE";
                                    precio = (int)(tel);
                                    break;

                                case 2:
                                    tel = (int)(200);
                                    tot = (int)(tel);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "TELEFONÍA ORO";
                                    precio = (int)(tel);
                                    break;
                                case 3:
                                    tel = (int)(300);
                                    tot = (int)(tel);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "TELEFONÍA PLATINUM";
                                    precio = (int)(tel);
                                    break;
                                case 4:
                                    Console.ReadKey();
                                    Console.WriteLine("Ingrese una opción válida");

                                    Console.Clear(); break;




                            }

                            break;


                        case 2:
                            Console.ReadKey();
                            Console.WriteLine("¿Qué plan de CABLE tiene activo?");
                            Console.WriteLine("\t Plan Bronce   ");
                            Console.WriteLine("\t Plan Oro    ");
                            Console.WriteLine("\t Plan Platinum ");
                            opci3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (opci3)
                            {

                                case 1:
                                    cab = (int)(150);
                                    tot = (int)(cab);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "CABLE BRONCE";
                                    precio = (int)(cab);
                                    break;

                                case 2:
                                    cab = (int)(250);
                                    tot = (int)(cab);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "CABLE ORO";
                                    precio = (int)(cab);
                                    break;
                                case 3:
                                    cab = (int)(350);
                                    tot = (int)(cab);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "CABLE PLATINUM";
                                    precio = (int)(cab);

                                    break;
                                case 4:

                                    Console.WriteLine("Ingrese una opción válida");
                                    Console.Clear();
                                    break;

                            }

                            break;


                        case 3:

                            Console.ReadKey();
                            Console.WriteLine("¿Qué plan de INTERNET tiene activo?");
                            Console.WriteLine("\t Plan Bronce  ");
                            Console.WriteLine("\t Plan Oro     ");
                            Console.WriteLine("\t Plan Platinum");
                            opci3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (opci3)
                            {

                                case 1:
                                    inte = (int)(200);
                                    tot = (int)(inte);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "INTERNET BRONCE";
                                    precio = (int)(inte);
                                    break;



                                case 2:
                                    inte = (int)(300);
                                    tot = (int)(inte);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "INTERNET ORO";
                                    precio = (int)(inte);
                                    break;

                                case 3:
                                    inte = (int)(400);
                                    tot = (int)(inte);
                                    desc = (int)(0);
                                    tot2 = (int)(tot - desc);
                                    plan = "INTERNET PLATINUM";
                                    precio = (int)(inte);
                                    break;
                                case 4:

                                    Console.WriteLine("Elija un opcion valida");
                                    Console.Clear();
                                    break;
                            }

                            break;

                        case 4:
                            Console.ReadKey();
                            Console.WriteLine("COMBO 1: 2 Planes BRONCE");
                            Console.WriteLine("Eliga dos planes BRONCE");
                            Console.WriteLine("\t 1. TELEFONÍA Y CABLE");
                            Console.WriteLine("\t 2. TELEFONÍA E INTERNET");
                            Console.WriteLine("\t 3. CABLE E INTERNET");
                            opci3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (opci3)
                            {

                                case 1:
                                    tel = (int)(100);
                                    cab = (int)(150);
                                    tot = (int)(tel + cab);
                                    desc = (int)(tot * 0.05);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO TELEFONÍA Y CABLE BRONCE";
                                    precio = (int)(tel + cab);
                                    break;

                                case 2:
                                    tel = (int)(100);
                                    equipo = (int)(150);
                                    tot = (int)(tel + inte);
                                    desc = (int)(tot * 0.05);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO TELEFONÍA E INTERNET BRONCE";
                                    precio = (int)(tel + inte);
                                    break;

                                case 3:
                                    cab = (int)(150);
                                    inte = (int)(200);
                                    tot = (int)(inte + cab);
                                    desc = (int)(tot * 0.05);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO CABLE E INTERNET BRONCE";
                                    precio = (int)(inte + cab);
                                    break;
                                case 4:

                                    Console.WriteLine("Ingrese una opcion valida");

                                    break;
                            }

                            break;

                        case 5:
                            Console.ReadKey();
                            Console.WriteLine("COMBO 2: 2 Planes ORO");
                            Console.WriteLine("Eliga dos planes ORO");
                            Console.WriteLine("\t 1. TELEFONÍA Y CABLE");
                            Console.WriteLine("\t 2. TELEFONÍA E INTERNET");
                            Console.WriteLine("\t 3. CABLE E INTERNET");
                            opci3 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (opci3)
                            {

                                case 1:
                                    tel = (int)(200);
                                    cab = (int)(250);
                                    tot = (int)(tel + cab);
                                    desc = (int)(tot * 0.07);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO TELEFONÍA Y CABLE ORO";
                                    break;
                                    precio = (int)(tel + cab);

                                case 2:
                                    tel = (int)(200);
                                    inte = (int)(300);
                                    tot = (int)(tel + inte);
                                    desc = (int)(tot * 0.07);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO TELEFONÍA E INTERNET ORO";
                                    precio = (int)(inte + tel);
                                    break;

                                case 3:
                                    cab = (int)(250);
                                    inte = (int)(300);
                                    tot = (int)(inte + cab);
                                    desc = (int)(tot * 0.07);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO CABLE E INTERNET";
                                    precio = (int)(inte + cab);
                                    break;
                                case 4:

                                    Console.WriteLine("Ingrese una opcion valida");

                                    break;
                            }
                            break;
                        case 6:
                            Console.ReadKey();
                            Console.WriteLine("COMBO 3: 2 Planes PLATINUM");
                            Console.WriteLine("Eliga dos planes PLATINUM");
                            Console.WriteLine("\t 1. TELEFONÍA Y CABLE");
                            Console.WriteLine("\t 2. TELEFONÍA E INTERNET");
                            Console.WriteLine("\t 3. CABLE E INTERNET");
                            opci3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (opci3)
                            {

                                case 1:
                                    tel = (int)(300);
                                    cab = (int)(350);
                                    tot = (int)(tel + cab);
                                    desc = (int)(tot * 0.10);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO TELEFONÍA Y CABLE PLATINUM";
                                    precio = (int)(tel + cab);
                                    break;

                                case 2:
                                    tel = (int)(300);
                                    inte = (int)(400);
                                    tot = (int)(tel + inte);
                                    desc = (int)(tot * 0.10);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO TELEFONÍA E INTERNET PLATINUM";
                                    precio = (int)(inte + tel);
                                    break;

                                case 3:
                                    cab = (int)(350);
                                    inte = (int)(400);
                                    tot = (int)(cab + inte);
                                    desc = (int)(tot * 0.10);
                                    tot2 = (int)(tot - desc);
                                    plan = "COMBO CABLE E INTERNET PLATINUM";
                                    precio = (int)(inte + cab);
                                    break;
                                case 4:

                                    Console.WriteLine("Ingrese una opcion valida");

                                    break;
                            }
                            break;

                        case 7:



                            tel = (int)(100);
                            cab = (int)(150);
                            inte = (int)(200);
                            tot = (int)(tel + cab + inte);
                            desc = (int)(tot * 0.06);
                            tot2 = (int)(tot - desc);
                            plan = "COMBO TELEFONÍA, CABLE E INTERNET BRONCE";
                            precio = (int)(tel + cab + inte);
                            break;

                        case 8:

                            tel = (int)(200);
                            cab = (int)(250);
                            inte = (int)(300);
                            tot = (int)(tel + cab + inte);
                            desc = (int)(tot * 0.08);
                            tot2 = (int)(tot - desc);
                            plan = "COMBO TELEFONÍA, CABLE E INTERNET ORO";
                            precio = (int)(tel + cab + inte);
                            break;

                        case 9:

                            tel = (int)(100);
                            cab = (int)(150);
                            inte = (int)(200);
                            tot = (int)(tel + cab + inte);
                            desc = (int)(tot * 0.12);
                            tot2 = (int)(tot - desc);
                            plan = "COMBO TELEFONÍA, CABLE E INTERNET PLATINUM";
                            precio = (int)(tel + cab + inte);
                            break;

                        case 10:

                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                    }
                    Console.ReadKey();
                    Console.WriteLine("SERVICIOS DE TELEFONÍA, CABLE E INTERNET");
                    Console.WriteLine("           CUILAPA SANTA ROSA");
                    Console.WriteLine("");
                    Console.WriteLine("RENOVACIÓN DEL MES: \t" + mes);
                    Console.WriteLine("");
                    Console.WriteLine("FACTURA NO:" + r.Next(1, 100));
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("NOMBRE:  \t" + name);
                    Console.WriteLine("");
                    Console.WriteLine("APELLIDO:\t" + apel);
                    Console.WriteLine("");
                    Console.WriteLine("DIRECCIÓN:\t" + direc);
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("PLAN ACTUAL:\t" + plan);
                    Console.WriteLine("");
                    Console.WriteLine("PRECIO DEL PLAN \t" + " Q" + precio);
                    Console.WriteLine("");
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("SUBTOTAL:  \t\t" + " Q" + tot);
                    Console.WriteLine("DESCUENTO AGREGADO:\t" + "-Q " + desc);
                    Console.WriteLine("\t                 ______");
                    Console.WriteLine("TOTAL A PAGAR  \t\t" + " Q" + tot2);
                    Console.WriteLine("______________________________________________________________________");
                }
            


            Console.WriteLine("");
            Console.WriteLine("Desea reaizar otra orden");
            Console.WriteLine("SI/NO");
            opcion = Console.ReadLine();
            Console.Clear();
           

        } while (opcion == "SI" || opcion == "si" || opcion == "Si" || opcion == "sI"); 
       

    }


}




        






        
    
