/// <reference path="../plugins/angular/angular.min.js" />

var myApp = angular.module("myModule", []);

myApp.controller("myController", myController)
myApp.service("Validation", Validation);
myApp.directive("ngDirective", ngDirective);

myController.$inject = ['$scope', 'Validation'];



function myController($scope, Validation) {
    $scope.checkNumber = function () { $scope.message = Validation.checkNumber($scope.num); }
}

function Validation($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return "Đây là số chẵn"
        }
        else {
            return "Đây là số lẻ"
        }
    }
}

function ngDirective() {
    return {
        restrict: "A",
        template: "<h1>Đây là Directive </h1>"
    }
}