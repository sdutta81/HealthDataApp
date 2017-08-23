const frisby = require('frisby');

var URL = "http://localhost:49765/";

describe("Test all end points", function () {
    it("Test profile", function (done) {
        frisby.get(URL + "/api/v1/profile")
            .expect("status", 200)
            .done(done)
    })

    it("Test User", function (done) {
        frisby.get(URL + "/api/v1/users/sdutta")
            .expect("status", 200)
            .done(done)
    })
})