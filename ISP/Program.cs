using ISP;
using ISP.PrinterISP;
using BasicPrinter = ISP.PrinterISP.BasicPrinter;



//IMultiFunctionPrinter printer = new BasicPrinter();
//printer.print();

////throws exception
//printer.fax();
//printer.scan();

IPrinter basicPrinter = new BasicPrinter();
basicPrinter.print();

IPrinter advPrinter = new AdvancedPrinter();
advPrinter.print();

IScanner advScaner = new AdvancedPrinter();
advScaner.scan();

IFax faxx = new AdvancedPrinter();
faxx.fax();