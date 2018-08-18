describe("Get API value", () => {
    //Mock the 'then' method
    let atomic = function () {
        return {
            then: function () {
                return {
                    apiValue: 5
                }
            }
        }
    };
    //Pass the mocked object
    let model = getModel(atomic);
    it("mocking the API", () => {
        //Use the model during the unit test
        let actual = model.getApiValue(6);
        expect(actual.apiValue).toBe(5);
    });
});